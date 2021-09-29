using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Renderable;
using NoDeskModels;
namespace NoDeskUI
{
    public partial class Dashboard : Form
    {
        private User _CurrentUser;
        private Login _login;

        public Dashboard(User user, Login login)
        {
            InitializeComponent();
            _CurrentUser = user;
            _login = login;
            LoginInitialize();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {
            TestCharts();
        }

        //tijdelijk 
        private void LoginInitialize()
        {

            LabelCurrentUser.Text = $"Current user: {_CurrentUser.Firstname} {_CurrentUser.Lastname}";
            LabelLicense.Text = $"Licensed to: {_CurrentUser.Company.CompanyName}";

        }

        private void MenuSwitch(string menuOption)
        {
            switch(menuOption)
            {
                case "Dashboard":

                    break;
                case "IncidentManagement":
                    IncidentManagement incidentManagement = new IncidentManagement(this, _login, _CurrentUser);
                    incidentManagement.Show();
                    this.Hide();
                    break;
                case "UserManagement":
                    UserManagment userManagment = new UserManagment(this, _login, _CurrentUser);
                    userManagment.Show();
                    this.Hide();
                    break;
                case "Logout":
                    this.Hide();
                    _login.Show();
                    break;
            }
        }


        private void TestCharts()
        {
            // chart 1
            double[] values = { 15, 35, 12 };
            string[] labels = { "Solved", "Unresolved", "Past deadline"};
            var PlotDayPie = formsPlotDayPie.Plot.AddPie(values);
            PlotDayPie.SliceLabels = labels;
            PlotDayPie.ShowLabels = true;
            PlotDayPie.Explode = true;
            PlotDayPie.SliceFillColors = new Color[] { Color.Green, Color.SteelBlue, Color.DarkOrange };
            formsPlotDayPie.Render();

            // chart 2
            // generate random data to plot
            int groupCount = 7;
            Random rand = new(0);
            double[] values1 = DataGen.RandomNormal(rand, groupCount, 20, 5);
            double[] values2 = DataGen.RandomNormal(rand, groupCount, 20, 5);
            double[] values3 = DataGen.RandomNormal(rand, groupCount, 20, 5);
            double[] errors1 = DataGen.RandomNormal(rand, groupCount, 0, 0);
            double[] errors2 = DataGen.RandomNormal(rand, groupCount, 0, 0);
            double[] errors3 = DataGen.RandomNormal(rand, groupCount, 0, 0);

            // group all data together
            string[] groupNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] seriesNames = { "Unresolved", "Past deadline", "Resolved" };
            double[][] valuesBySeries = { values1, values2, values3 };
            double[][] errorsBySeries = { errors1, errors2, errors3 };

            chartWeek.ForeColor = Color.Red;

            // add the grouped bar plots and show a legend
            chartWeek.Plot.AddBarGroups(groupNames, seriesNames, valuesBySeries, errorsBySeries);
            chartWeek.Plot.Legend(location: Alignment.UpperRight);



            chartWeek.BackColor = Color.White;
            chartWeek.Plot.SetAxisLimits(yMin: 0);
            
            chartWeek.Render();
        }

        private void IMBTN_Click(object sender, EventArgs e)
        {
            MenuSwitch("IncidentManagement");
        }

        private void UMBTN_Click(object sender, EventArgs e)
        {
            MenuSwitch("UserManagement");
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MenuSwitch("Logout");
        }

    }
}

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
namespace NoDeskUI
{
    public partial class UserManagment : Form
    {
        private Dashboard _dashboard;

        public UserManagment(Dashboard dashboard)
        {
            _dashboard = dashboard;
            InitializeComponent();
            LoginInitialize();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {
            
        }

        //tijdelijk 
        private void LoginInitialize()
        {

            LabelCurrentUser.Text = $"Current user: {"Bastiaan van der bijl"}";
            LabelLicense.Text = $"Licensed to: {"The Garden Group"}";

        }

        private void MenuSwitch(string menuOption)
        {
            switch (menuOption)
            {
                case "Dashboard":
                    _dashboard.Show();
                    this.Hide();
                    break;
                case "IncidentManagement":
                    IncidentManagement incidentManagement = new IncidentManagement(_dashboard);
                    incidentManagement.Show();
                    this.Hide();
                    break;
                case "UserManagement":

                    break;
            }
        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            MenuSwitch("Dashboard");
        }

        private void IMBTN_Click_1(object sender, EventArgs e)
        {
            MenuSwitch("IncidentManagement");
        }
    }
}

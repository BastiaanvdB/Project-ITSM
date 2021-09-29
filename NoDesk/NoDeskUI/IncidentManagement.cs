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
    public partial class IncidentManagement : Form
    {
        private Dashboard _dashboard;

        public IncidentManagement(Dashboard dashboard)
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

                    break;
                case "UserManagement":
                    UserManagment userManagment = new UserManagment(_dashboard);
                    userManagment.Show();
                    this.Hide();
                    break;
            }
        }

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            MenuSwitch("Dashboard");
        }

        private void UMBTN_Click(object sender, EventArgs e)
        {
            MenuSwitch("UserManagement");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

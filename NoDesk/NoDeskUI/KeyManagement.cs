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
    public partial class KeyManagement : Form
    {
        private User _CurrentUser;
        private Login _login;
        private Dashboard _dashboard;

        public KeyManagement(Dashboard dashboard, Login login, User user)
        {
            InitializeComponent();
            _dashboard = dashboard;
            _CurrentUser = user;
            _login = login;
            LoginInitialize();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {

        }

        private void LoginInitialize()
        {

            LabelCurrentUser.Text = $"Current user: {_CurrentUser.Firstname} {_CurrentUser.Lastname}";
            LabelLicense.Text = $"Licensed to: {_CurrentUser.Company.CompanyName}";

            switch(_CurrentUser.Role)
            {
                case Roles.user:
                    APBTN.Hide();
                    KMBTN.Hide();
                    break;
                case Roles.admin:
                    APBTN.Show();
                    KMBTN.Hide();
                    break;
                case Roles.god:
                    UMBTN.Hide();
                    IMBTN.Hide();
                    APBTN.Show();
                    KMBTN.Show();
                    break;
            }
        }

        private void MenuSwitch(string menuOption)
        {
            switch(menuOption)
            {
                case "Dashboard":
                    _dashboard.Show();
                    this.Hide();
                    break;
                case "IncidentManagement":
                    IncidentManagement incidentManagement = new IncidentManagement(_dashboard, _login, _CurrentUser);
                    incidentManagement.Show();
                    this.Hide();
                    break;
                case "UserManagement":
                    UserManagment userManagment = new UserManagment(_dashboard, _login, _CurrentUser);
                    userManagment.Show();
                    this.Hide();
                    break;
                case "Logout":
                    this.Hide();
                    _login.Show();
                    break;
            }
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

        private void DashboardBTN_Click(object sender, EventArgs e)
        {
            MenuSwitch("Dashboard");
        }
    }
}

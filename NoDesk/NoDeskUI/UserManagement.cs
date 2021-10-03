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
using NoDeskLogic;
using NoDeskModels;

namespace NoDeskUI
{
    public partial class UserManagment : Form
    {
        private Dashboard _dashboard;
        private User_Service _us;
        private Login _login;
        private User _currentUser;
        public UserManagment(Dashboard dashboard, Login login, User user)
        {
            _dashboard = dashboard;
            _login = login;
            _currentUser = user;
            _us = new User_Service();
            InitializeComponent();
            LoginInitialize();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {
            FillListView();
        }

        private void LoginInitialize()
        {
            LabelCurrentUser.Text = $"Current user: {_currentUser.Firstname} {_currentUser.Lastname}";
            LabelLicense.Text = $"Licensed to: {_currentUser.Company.CompanyName}";
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
                    IncidentManagement incidentManagement = new IncidentManagement(_dashboard, _login, _currentUser);
                    incidentManagement.Show();
                    this.Hide();
                    break;
                case "KeyManagement":
                    KeyManagement keyManagement = new KeyManagement(_dashboard, _login, _currentUser);
                    keyManagement.Show();
                    this.Hide();
                    break;
                case "Logout":
                    this.Hide();
                    _login.Show();
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

        private void FillListView()
        {
            List<User> users = _us.GetUsers();

            lst_UM_Users.Items.Clear();

            foreach (var user in users)
            {
                //ListViewItem User = new ListViewItem(user.Id.ToString());

                //User.SubItems.Add(user.FirstName);
                //User.SubItems.Add(user.LastName.ToString());
                //User.SubItems.Add(user.Job);

                //lst_UM_Users.Items.Add(User);
            }
        }

        private void btn_UM_AddUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_UM_EditUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_UM_DeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_UM_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void btn_UM_AddUser_Confirm_Click(object sender, EventArgs e)
        {
            //Guid Id = txt_UM_AddUser_Id.Text;
            //string FirstName = txt_UM_AddUser_FirstName.Text;
            //string LastName = txt_UM_AddUser_LastName.Text;
                          
            //_us.AddUser(new User());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MenuSwitch("IncidentManagement");
        }

        private void buttonKeyManagement_Click(object sender, EventArgs e)
        {
            MenuSwitch("KeyManagement");
        }
    }
}

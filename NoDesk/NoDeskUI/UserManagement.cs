using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using NoDeskLogic;
using NoDeskModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

            List<User> UserList = _us.GetUsers();        

            lst_UM_Users.Items.Clear();

            foreach (var user in UserList)
            {
                //Makes sure the person who is logged in only sees users from their company
                if (user.Company.CompanyName == _currentUser.Company.CompanyName)
                {
                    ListViewItem User = new ListViewItem(user.Id.ToString());

                    User.SubItems.Add(user.Firstname);
                    User.SubItems.Add(user.Lastname);
                    User.SubItems.Add(user.Email);
                    User.SubItems.Add(user.Company.CompanyName);

                    lst_UM_Users.Items.Add(User);
                }
                
            }
        }

        private void btn_UM_EditUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_UM_DeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void btn_UM_Refresh_Click(object sender, EventArgs e)
        {
            FillListView();
        }      

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MenuSwitch("Logout");
        }
    }
}

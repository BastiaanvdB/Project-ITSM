using MongoDB.Bson;
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
            List<BsonDocument> users = _us.GetUsers();

            List<User> UserList = new List<User>();

            //Fill the UserList with User objects containing only the desired information from the BsonDocuments from the DB
            foreach (var rec in users)
            {
                User user = new User();
                user.Id = (ObjectId)rec.GetValue("_id");
                user.Firstname = (string)rec.GetValue("Firstname");
                user.Lastname = (string)rec.GetValue("Lastname");
                user.Email = (string)rec.GetValue("Email");
                
                UserList.Add(user);
            }


            lst_UM_Users.Items.Clear();

            foreach (var user in UserList)
            {
                ListViewItem User = new ListViewItem(user.Id.ToString());

                User.SubItems.Add(user.Firstname);
                User.SubItems.Add(user.Lastname);
                User.SubItems.Add(user.Email);

                lst_UM_Users.Items.Add(User);
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
            FillListView();
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
            MenuSwitch("Logout");
        }
    }
}

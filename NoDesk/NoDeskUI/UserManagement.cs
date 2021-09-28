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
        

        public UserManagment(Dashboard dashboard)
        {
            _dashboard = dashboard;
            _us = new User_Service();
            InitializeComponent();
            LoginInitialize();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {
            FillListView();
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
    }
}

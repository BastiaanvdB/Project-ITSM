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
            pnl_UpdateUser.Hide();
            FillDataGrid();
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

        private void FillDataGrid()
        {

            List<User> UserList = _us.GetUsers();

            //lst_UM_Users.Items.Clear();

            foreach (var user in UserList)
            {
                //Makes sure the person who is logged in only sees users from their company
                if (user.Company.CompanyName == _currentUser.Company.CompanyName)
                {
                    //DataGridViewRow row = new DataGridViewRow();
                    dgv_UserData.Rows.Add(user.Id, user.Firstname, user.Lastname, user.Email, user.Company.CompanyName);                           
                }

            }                 
        }

        private void btn_UM_EditUser_Click(object sender, EventArgs e)
        {
            pnl_UpdateUser.Show();
        }

        private void btn_UpdateUserConfirm_Click(object sender, EventArgs e)
        {
            if (dgv_UserData.SelectedRows.Count == 1)
            {
                ObjectId Id = ObjectId.Parse(dgv_UserData.Rows[dgv_UserData.SelectedRows[0].Index].Cells[0].Value.ToString());
                User user = _us.GetUserById(Id);
                string NewEmail = txt_NewEmailInput.Text;


                DialogResult msbResult = MessageBox.Show("Are you sure you want to update the selected user?", "Update", MessageBoxButtons.YesNo);
                if (msbResult == DialogResult.Yes)
                {
                    user.Email = NewEmail;
                    _us.UpdateUser(user);
                    MessageBox.Show("User succesfully updated!", "Update Confirmed", MessageBoxButtons.OK);
                    txt_NewEmailInput.Clear();
                    pnl_UpdateUser.Hide();
                }
            }
            
        }

        private void btn_UM_DeleteUser_Click(object sender, EventArgs e)
        {
            if (dgv_UserData.SelectedRows.Count == 1)
            {
                ObjectId Id = ObjectId.Parse(dgv_UserData.Rows[dgv_UserData.SelectedRows[0].Index].Cells[0].Value.ToString());
                User user = _us.GetUserById(Id);
                DialogResult msbResult = MessageBox.Show("Are you sure you want to delete the selected user?", "Delete", MessageBoxButtons.YesNo);
                if (msbResult == DialogResult.Yes)
                {
                    _us.DeleteUserById(user);
                    MessageBox.Show("User succesfully deleted!", "Delete Confirmed", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please select an user first!", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void btn_CancelUpdateUser_Click(object sender, EventArgs e)
        {
            txt_NewEmailInput.Clear();
            pnl_UpdateUser.Hide();
        }

        private void btn_UM_Refresh_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }      

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MenuSwitch("Logout");
        }

    }
}

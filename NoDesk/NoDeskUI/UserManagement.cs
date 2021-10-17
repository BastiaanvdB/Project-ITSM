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
            dgv_UserData.ClearSelection();
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

        private void FillDataGrid()
        {
            
            List<User> UserList = _us.GetUsers();          

            foreach (var user in UserList)
            {
                //Makes sure the person who is logged in only sees users from their company
                if (user.Company.CompanyName == _currentUser.Company.CompanyName)
                {                 
                    dgv_UserData.Rows.Add(user.Id, user.Firstname, user.Lastname, user.Email, user.Company.CompanyName, user.Role);                           
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

                if (txt_NewEmailInput.Text != "")
                {
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
                else
                {
                    MessageBox.Show("Please enter an email address before submitting", "Empty field", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                MessageBox.Show("Please select an user first!", "Nothing Selected", MessageBoxButtons.OK);
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
            dgv_UserData.Rows.Clear();
            FillDataGrid();
            dgv_UserData.ClearSelection();
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

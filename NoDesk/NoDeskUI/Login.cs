using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoDeskUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginFormStart();
        }

        private void LoginFormStart()
        {
            panelLogin.Show();
            panelRegistration.Hide();
        }

        private void LoginMenu(string option)
        {
            switch(option)
            {
                case "registration":
                    panelLogin.Hide();
                    panelRegistration.Show();
                    break;
                case "forgotPassword":

                    break;
            }
        }

        private void RegistrationSetting(string mode)
        {
            switch(mode)
            {
                case "user":
                    groupBoxKey.Text = "Enter invitation code ";
                    groupBoxCompany.Text = "Invited by";
                    textBoxCompany.Enabled = false;
                    break;
                case "admin":
                    groupBoxKey.Text = "Enter activation code ";
                    groupBoxCompany.Text = "Enter company name";
                    textBoxCompany.Enabled = true;
                    break;
            }
        }



        private void BTNLogin_Click(object sender, EventArgs e)
        {
            // tijdelijk
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void linkLabelFP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMenu("forgotPassword");
        }

        private void linkLabelR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginMenu("registration");
        }

        private void radioButtonCompany_CheckedChanged(object sender, EventArgs e)
        {
            RegistrationSetting("admin");
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            RegistrationSetting("user");
        }
    }
}

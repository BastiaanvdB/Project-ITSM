using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoDeskModels;

namespace NoDeskUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            LoginFormStart();
        }

        // login section
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
                    SetFormDefault();
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
                    groupBoxKey.Text = "Enter invitation key ";
                    groupBoxCompany.Text = "Invited by";
                    break;
                case "admin":
                    groupBoxKey.Text = "Enter activation key ";
                    groupBoxCompany.Text = "Company name";
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

        /// Registration section
        private void RegistrationKeyCheck()
        {
            if (textBoxKey.Text.Length > 0)
            {
                Encryption encryption = new Encryption();
                KeyCheck activationCheck = new KeyCheck();
                string key = "";
                string[] keys = new string[2];
                bool keyCheck = false;

                if (radioButtonCompany.Checked == true)
                {
                    try
                    {
                        key = encryption.Decrypt(textBoxKey.Text);
                        keyCheck = activationCheck.CheckActivationKey(key);
                    }
                    catch (Exception ex)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(ex.Message, "Activation key issue", buttons, MessageBoxIcon.Warning);
                    }
                    if (keyCheck == true)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Activation key was accepted", "Correct activation key", buttons, MessageBoxIcon.Information);

                        textBoxCompany.Text = keys[0];
                        textBoxKey.Enabled = false;
                        buttonEnterKey.Enabled = false;
                        SetTextboxes(true);
                    }
                }

                else
                {
                    try
                    {
                        key = encryption.Decrypt(textBoxKey.Text);
                        keyCheck = activationCheck.CheckInviteKey(key);
                    }
                    catch (Exception ex)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(ex.Message, "Invitation key issue", buttons, MessageBoxIcon.Warning);
                    }

                    if (keyCheck == true)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Invitation key was accepted", "Correct invitation key", buttons, MessageBoxIcon.Information);

                        textBoxCompany.Text = keys[0];
                        textBoxKey.Enabled = false;
                        buttonEnterKey.Enabled = false;
                        SetTextboxes(true);
                    }
                }
            
            }
            else
            {
                // voeg popup toe met error 
            }
        }

        private void SetFormDefault()
        {
            ClearTextboxes();
            SetTextboxes(false);
            buttonRegister.Enabled = false;
            textBoxKey.Enabled = true;
            buttonEnterKey.Enabled = true;
        }


        private void ClearTextboxes()
        {
            textBoxKey.Clear();
            textBoxCompany.Clear();
            txtRegFirstname.Clear();
            txtRegLastname.Clear();
            txtRegEmail.Clear();
            txtRegPassword.Clear();
            txtRegPasswordretry.Clear();
        }

        private void SetTextboxes(bool set)
        {
            txtRegFirstname.Enabled = set;
            txtRegLastname.Enabled = set;
            txtRegEmail.Enabled = set;
            txtRegPassword.Enabled = set;
            txtRegPasswordretry.Enabled = set;
        }

        private void buttonEnterKey_Click(object sender, EventArgs e)
        {
            RegistrationKeyCheck();
        }

        private void radioButtonCompany_CheckedChanged(object sender, EventArgs e)
        {
            RegistrationSetting("admin");
            SetFormDefault();
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            RegistrationSetting("user");
            SetFormDefault();
        }

        /// Forgot Password section
    }
}

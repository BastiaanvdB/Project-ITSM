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
using NoDeskLogic;
using MongoDB.Bson;

namespace NoDeskUI
{
    public partial class Login : Form
    {
        private Company_Service _company_Service;
        private User_Service _user_Service;
        private Encryption _encryption;
        KeyCheck _activationCheck;
        public Login()
        {
            InitializeComponent();
            LoginFormStart();
            _company_Service = new Company_Service();
            _user_Service = new User_Service();
            _encryption = new Encryption();
            _activationCheck = new KeyCheck();
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
                bool keyCheck = false;

                if (radioButtonCompany.Checked == true)
                {
                    try
                    {
                        keyCheck = _activationCheck.EnterActivationKey(textBoxKey.Text);
                        if ((_company_Service.CheckActivationKeyIfUsed(textBoxKey.Text) == false) && (keyCheck == true))
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Activation key was accepted", "Correct activation key", buttons, MessageBoxIcon.Information);
                            textBoxCompany.Text = _activationCheck.CompanyName;
                            textBoxKey.Enabled = false;
                            buttonEnterKey.Enabled = false;
                            buttonRegister.Enabled = true;
                            SetTextboxes(true);
                        }
                        else
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Please enter a valid or unused key", "Key issue", buttons, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(ex.Message, "Activation key issue", buttons, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    try
                    {
                        keyCheck = _activationCheck.EnterInviteKey(textBoxKey.Text);
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
                        Company company = _company_Service.GetCompanyById(new ObjectId(_activationCheck.CompanyID));
                        textBoxCompany.Text = company.CompanyName;
                        textBoxKey.Enabled = false;
                        buttonEnterKey.Enabled = false;
                        buttonRegister.Enabled = true;
                        SetTextboxes(true);
                    }
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Please enter a key", "No key entered", buttons, MessageBoxIcon.Warning);
            }
        }

        private void CreateCompany()
        {
            Company company = new Company
            {
                CompanyName = textBoxCompany.Text,
                ActivationKey = textBoxKey.Text
            };
            InsertCompany(company);
        }

        private void InsertCompany(Company company)
        {
            try
            {
                _company_Service.InsertCompany(company);
            }
            catch (Exception)
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("The registration failed, try again later..", "Registration failure", button, MessageBoxIcon.Error);
            }
        }

        private Company GetCompanyById(string id)
        {
            return _company_Service.GetCompanyById(new ObjectId(id));
        }

        private Company GetCompanyByActivationKey()
        {
            return _company_Service.GetCompanyByActivationKey(textBoxKey.Text);
        }

        private void CreateAdmin()
        {
            CreateCompany();

            if ((txtRegEmail.Text.Contains('@') == true) && ((txtRegEmail.Text.Contains('.'))))
            {
                if ((txtRegFirstname.Text.Length > 0) && (txtRegLastname.Text.Length > 0) && (txtRegEmail.Text.Length > 0) && (txtRegPassword.Text.Length > 0) && (txtRegPasswordretry.Text.Length > 0))
                {
                    if (txtRegPassword.Text == txtRegPasswordretry.Text)
                    {
                        User admin = new User
                        {
                            Firstname = txtRegFirstname.Text,
                            Lastname = txtRegLastname.Text,
                            Email = txtRegEmail.Text,
                            Password = _encryption.Encrypt(txtRegPassword.Text),
                            Company = GetCompanyByActivationKey(),
                            Role = Roles.admin,
                            ActivationKey = textBoxKey.Text
                        };
                        InsertUser(admin);
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Make sure that both passwords are the same!", "Registration password issue", buttons, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Make sure that all boxes are filled!", "Registration issue", buttons, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Enter a valid email address!", "Registration issue", buttons, MessageBoxIcon.Warning);
            }
        }
        
        private void CreateUser()
        {
            if ((txtRegEmail.Text.Contains('@') == true) && ((txtRegEmail.Text.Contains('.') == true)))
            {
                if ((txtRegFirstname.Text.Length > 0) && (txtRegLastname.Text.Length > 0) && (txtRegEmail.Text.Length > 0) && (txtRegPassword.Text.Length > 0) && (txtRegPasswordretry.Text.Length > 0))
                {
                    if (txtRegPassword.Text == txtRegPasswordretry.Text)
                    {
                        User user = new User
                        {
                            Firstname = txtRegFirstname.Text,
                            Lastname = txtRegLastname.Text,
                            Email = txtRegEmail.Text,
                            Password = _encryption.Encrypt(txtRegPassword.Text),
                            Company = GetCompanyById(_activationCheck.CompanyID),
                            Role = Roles.user,
                            ActivationKey = textBoxKey.Text
                        };
                        InsertUser(user);
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Make sure that both passwords are the same!", "Registration password issue", buttons, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Make sure that all boxes are filled!", "Registration password issue", buttons, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Enter a valid email address!", "Registration password issue", buttons, MessageBoxIcon.Warning);
            }
        }

        private void InsertUser(User user)
        {
            try
            {
                _user_Service.InsertUser(user);
            }
            catch (Exception)
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show("The registration failed, try again later..", "Registration failure", button, MessageBoxIcon.Error);
            }
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("The account is created successful! You can proceed to login", "Registration successful", buttons, MessageBoxIcon.Information);
            TextboxUsername.Text = txtRegEmail.Text;
            TextboxPassword.Clear();
            ClearTextboxes();
            panelRegistration.Hide();
            panelLogin.Show();
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(radioButtonCompany.Checked is true)
            {
                CreateAdmin();
            }
            else
            {
                CreateUser();
            }
        }

        /// Forgot Password section
    }
}

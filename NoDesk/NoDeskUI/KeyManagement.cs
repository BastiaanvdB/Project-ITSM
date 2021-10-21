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
using NoDeskLogic;
namespace NoDeskUI
{
    public partial class KeyManagement : Form
    {
        private User _CurrentUser;
        private Login _login;
        private Dashboard _dashboard;
        private KeyCheck _keyCheck;
        private Company_Service _company_service;
        private User_Service _user_Service;
        private List<Company> _companies;
        public KeyManagement(Dashboard dashboard, Login login, User user)
        {
            InitializeComponent();
            _keyCheck = new KeyCheck();
            _company_service = new Company_Service();
            _user_Service = new User_Service();
            _dashboard = dashboard;
            _CurrentUser = user;
            _login = login;
            LoginInitialize();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {
            buttonCopy.Enabled = false;
            LoadCompanies();
            FillCompanyListview();
        }

        private void LoginInitialize()
        {
            LabelCurrentUser.Text = $"Current user: {_CurrentUser.Firstname} {_CurrentUser.Lastname}";
            LabelLicense.Text = $"Licensed to: {_CurrentUser.Company.CompanyName}";

            switch(_CurrentUser.Role)
            {
                case Roles.user:
                    KMBTN.Hide();
                    UMBTN.Hide();
                    break;
                case Roles.admin:
                    KMBTN.Hide();
                    break;
                case Roles.god:
                    UMBTN.Show();
                    IMBTN.Show();
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

        public void LoadCompanies()
        {
            _companies = _company_service.GetCompanies();
        }

        public void FillCompanyListview()
        {
   
            foreach (Company company in _companies)
            {
                listViewRegisteredCompanies.Items.Add(new ListViewItem(new string[] { $"{company.CompanyName}", $"{_user_Service.GetUserByKey(company.ActivationKey).Firstname + " " + _user_Service.GetUserByKey(company.ActivationKey).Lastname }", $"{_user_Service.GetUserByKey(company.ActivationKey).Email}", $"{_user_Service.LoadUsersByCompanyName(company.CompanyName).Count}" }));
            }
        }

        public void GenerateKey()
        {
            if (textBoxCompanyName.Text.Length > 0)
            {
                textBoxKeyOutput.Text = _keyCheck.CreateActivationKey(textBoxCompanyName.Text);
                buttonCopy.Enabled = true;
            }
            else
            {
                buttonCopy.Enabled = false;
                textBoxKeyOutput.Clear();
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Enter a company name!", "Error at generating key", buttons, MessageBoxIcon.Warning);
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

        private void buttonGenerateKey_Click(object sender, EventArgs e)
        {
            GenerateKey();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxKeyOutput.Text);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Key copied to clipboard", "", buttons, MessageBoxIcon.Information);
        }
    }
}

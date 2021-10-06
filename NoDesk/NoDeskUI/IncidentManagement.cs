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
    public partial class IncidentManagement : Form
    {
        private Dashboard _dashboard;
        private Ticket_Service _ticketService;
        private Login _login;
        private User _currentUser;
        public IncidentManagement(Dashboard dashboard, Login login, User user)
        {
            _dashboard = dashboard;
            _login = login;
            _currentUser = user;
            InitializeComponent();
            LoginInitialize();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {
           // FillListview();
        }

        private void LoginInitialize()
        {
            PNL_CreateTicket.Hide();
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
                case "UserManagement":
                    UserManagment userManagment = new UserManagment(_dashboard, _login, _currentUser);
                    userManagment.Show();
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

        private void UMBTN_Click(object sender, EventArgs e)
        {
            MenuSwitch("UserManagement");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            MenuSwitch("Logout");
        }

        private void BTN_CloseNewIncident_Click(object sender, EventArgs e)
        {
            PNL_CreateTicket.Hide();
        }

        private void BTN_NewTicket_Click(object sender, EventArgs e)
        {
            PNL_CreateTicket.Show();
        }

        private void BTN_Transfer_Click(object sender, EventArgs e)
        {
            if (TXT_UserTransfer.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to transfer the ticket from {} to {}?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do it
                }
                else if (dialogResult == DialogResult.No)
                {
                    TXT_UserTransfer.Clear();
                }
            }
            else
            {
                MessageBox.Show("Oops, please make sure to enter a user!");
            }
        }

        private void BTN_ConfirmTicket_Click(object sender, EventArgs e)
        {
            //if (TXTBOX_Subject.Text != "" && ComboBox_Type.SelectedItem.ToString && TXTBOX_User.Text != "" && ComboBox_Priority.ToString != "" && DateTime_Deadline != "" && TXTBOX_Description.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to create a new incident ticket?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do it
                }
                else if (dialogResult == DialogResult.No)
                {
                    //don't do it
                }
            }
        }

       // private void FillListview()
        //{
            //List<Ticket> tickets = _ticketService.GetTickets();

            //LSV_Ticketoverview.Items.Clear();

           // foreach (var ticket in tickets)
           // {
               // ListViewItem Ticket = new ListViewItem(ticket.User);

               // Ticket.SubItems.Add(ticket.Date.ToString());
               // Ticket.SubItems.Add(ticket.Type);
               // Ticket.SubItems.Add(ticket.Subject);
               // Ticket.SubItems.Add(ticket.Priority);
               // Ticket.SubItems.Add(ticket.Deadline.ToString());
               // Ticket.SubItems.Add(ticket.Description);

               // LSV_Ticketoverview.Items.Add(Ticket);
           // }
        //}
    }
}

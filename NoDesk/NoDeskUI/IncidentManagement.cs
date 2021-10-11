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
            _ticketService = new Ticket_Service();
            InitializeComponent();
            LoginInitialize();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {
            PNL_CreateTicket.Hide();
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


        // Transfer ticket to another user

        private void BTN_Transfer_Click(object sender, EventArgs e)
        {
            if (TXT_UserTransfer.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to transfer the ticket from {} to {}?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Ticket ticket = new Ticket();

                    //ticket.Id =  DGV_Incidents.Rows[DGV_Incidents.SelectedRows[0].Index].Cells[0].Value.ToString(); 
                    ticket.User = TXT_UserTransfer.Text.ToString();

                    _ticketService.UpdateTicket(ticket);
                }
                else if (dialogResult == DialogResult.No)
                {
                    TXT_UserTransfer.Clear();
                }
            }
            else
            {
                MessageBox.Show("Oops, please make sure to enter the user you would like to transfer the ticket to!");
            }
        }

        


        // Create a new incident ticket

        private void BTN_ConfirmTicket_Click(object sender, EventArgs e)
        {
            //if (TXTBOX_Subject.Text != "" && ComboBox_Type.SelectedItem.ToString && TXTBOX_User.Text != "" && ComboBox_Priority.ToString != "" && DateTime_Deadline != "" && TXTBOX_Description.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to create a new incident ticket?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Ticket ticket = new Ticket();

                    ticket.Subject = TXTBOX_Subject.Text;
                    //ticket.Type = Enum.Parse(typeof(Type), ComboBox_Type.Text);
                    ticket.User = TXTBOX_User.Text;
                    //ticket.Priority = Enum.Parse(typeof(Type), ComboBox_Priority.Text);
                    ticket.Deadline = DateTime_Deadline.Value;
                    ticket.Description = TXTBOX_Description.Text;
                    ticket.Date = DateTime.Now;                     // Datum van creëren is automatisch nu

                    _ticketService.InsertTicket(ticket);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //don't do it
                }
            }
            //else
            {
                //MessageBox.Show("Oops, please make sure to enter all fields!");
            }
        }




        // Fill the datagrid with incidents

        private void FillDataGrid()
        {
            List<Ticket> TicketList = _ticketService.GetTickets();

            foreach (var ticket in TicketList)
            {
                DGV_Incidents.Rows.Add(ticket.Id, ticket.Subject, ticket.User, ticket.Date, ticket.Deadline);
            }
        }
    }
}

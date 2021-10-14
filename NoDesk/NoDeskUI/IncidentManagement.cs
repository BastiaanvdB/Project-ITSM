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
using MongoDB.Bson;

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
            FillComboBoxType();
            FillComboBoxPriority();
            FullRowSelect();
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

        private void FullRowSelect()
        {
            DGV_Incidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }



        // Transfer ticket to another user

        private void BTN_Transfer_Click(object sender, EventArgs e)
        {
            if (DGV_Incidents.SelectedRows.Count == 1)
            {
                ObjectId Id = ObjectId.Parse(DGV_Incidents.Rows[DGV_Incidents.SelectedRows[0].Index].Cells[0].Value.ToString());
                Ticket ticket = _ticketService.GetTicketById(Id);

                if (TXT_UserTransfer.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to transfer the ticket?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        ticket.Creator = TXT_UserTransfer.Text;

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
            else
            {
                MessageBox.Show("Oops, please make sure to select the user you would like to update");
            }
        }

        



        // Create a new incident ticket

        private void BTN_ConfirmTicket_Click(object sender, EventArgs e)
        {
            if (TXTBOX_Subject.Text != "" && ComboBox_Type != null && TXTBOX_User.Text != "" && ComboBox_Priority != null && DateTime_Deadline != null && TXTBOX_Description.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to create a new incident ticket?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Ticket ticket = new Ticket();

                    ticket.Subject = TXTBOX_Subject.Text;



                    string Type = ComboBox_Type.Text;
                    if (Type == "Hardware")
                    {
                        ticket.Type = TypeIncident.Hardware;
                    }
                    else if (Type == "Software")
                    {
                        ticket.Type = TypeIncident.Software;
                    }
                    else if (Type == "Service")
                    {
                        ticket.Type = TypeIncident.Service;
                    }
                    ticket.Creator = TXTBOX_User.Text;


                  
                    string priority = ComboBox_Priority.Text;
                    if (priority == "Low")
                    {
                        ticket.Priority = Priority.Low;
                    }
                    else if (priority == "Medium")
                    {
                        ticket.Priority = Priority.Medium;
                    }
                    else if (priority == "High")
                    {
                        ticket.Priority = Priority.High;
                    }



                    ticket.ClosedAt = DateTime_Deadline.Value;
                    ticket.Text = TXTBOX_Description.Text;
                    ticket.CreatedAt = DateTime.Now;                    // Datum van creëren is automatisch nu
                    ticket.Status = TicketStatus.Open;                  // Status is automatisch open

                    _ticketService.InsertTicket(ticket);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //don't do it
                }
            }
            else
            {
                MessageBox.Show("Oops, please make sure to enter all fields!");
            }
        }




        // Fill the datagrid with incidents

        private void FillDataGrid()
        {
            List<Ticket> TicketList = _ticketService.GetTickets();

            foreach (var ticket in TicketList)
            {
                DGV_Incidents.Rows.Add(ticket.Id, ticket.Subject, ticket.Creator, ticket.Priority, ticket.ClosedAt, ticket.Status, ticket.Text);
            }
        }


        // Fill combo boxen

        private void FillComboBoxType()
        {
            List<TypeIncident> typesList = new List<TypeIncident>();
            Array Types = Enum.GetValues(typeof(TypeIncident));

            foreach (TypeIncident type in Types)
            {
                typesList.Add(type);
            }

            ComboBox_Type.DataSource = typesList;
        }

        private void FillComboBoxPriority()
        {
            List<Priority> priorityList = new List<Priority>();
            Array Priorities = Enum.GetValues(typeof(Priority));

            foreach (Priority priority in Priorities)
            {
                priorityList.Add(priority);
            }

            ComboBox_Priority.DataSource = priorityList;
        }


        // Change status to 

        private void BTN_ChangeStatus_Click(object sender, EventArgs e)
        {
            if (DGV_Incidents.SelectedRows.Count == 1)
            {
                ObjectId Id = ObjectId.Parse(DGV_Incidents.Rows[DGV_Incidents.SelectedRows[0].Index].Cells[0].Value.ToString());
                Ticket ticket = _ticketService.GetTicketById(Id);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to change the status to closed?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ticket.Status = TicketStatus.Closed;
                    _ticketService.UpdateTicket(ticket);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // Do not do it
                }

            }
            else
            {
                MessageBox.Show("Oops, please make sure to select the incident you would like to close!");
            }
        }



        // Search user in datagrid

        private void BTN_Search_Click(object sender, EventArgs e)
        {
            string searchValue = TXTBox_Search.Text;

            DGV_Incidents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in DGV_Incidents.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}

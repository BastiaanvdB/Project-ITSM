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
using System.Globalization;

namespace NoDeskUI
{
    public partial class Dashboard : Form
    {
        private User _CurrentUser;
        private Login _login;
        private Ticket_Service _ticket_Service;

        public Dashboard(User user, Login login)
        {
            InitializeComponent();
            _CurrentUser = user;
            _login = login;
            _ticket_Service = new Ticket_Service();
            LoginInitialize();
        }

        private void NoDesk_Load(object sender, EventArgs e)
        {
            LoadCharts();
        }

        private void LoginInitialize()
        {

            LabelCurrentUser.Text = $"Current user: {_CurrentUser.Firstname} {_CurrentUser.Lastname}";
            LabelLicense.Text = $"Licensed to: {_CurrentUser.Company.CompanyName}";

            switch(_CurrentUser.Role)
            {
                case Roles.user:
                    KMBTN.Hide();
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

            System.Windows.Forms.Timer timerDiagram = new System.Windows.Forms.Timer();
            timerDiagram.Interval = 20000;//20 seconds
            timerDiagram.Tick += new System.EventHandler(timerDiagram_Tick);
            timerDiagram.Start();
        }

        private void timerDiagram_Tick(object sender, EventArgs e)
        {
            LoadCharts();
        }

        private void MenuSwitch(string menuOption)
        {
            switch(menuOption)
            {
                case "Dashboard":

                    break;
                case "IncidentManagement":
                    IncidentManagement incidentManagement = new IncidentManagement(this, _login, _CurrentUser);
                    incidentManagement.Show();
                    this.Hide();
                    break;
                case "UserManagement":
                    UserManagment userManagment = new UserManagment(this, _login, _CurrentUser);
                    userManagment.Show();
                    this.Hide();
                    break;
                case "KeyManagement":
                    KeyManagement keyManagement = new KeyManagement(this, _login, _CurrentUser);
                    keyManagement.Show();
                    this.Hide();
                    break;
                case "Logout":
                    this.Hide();
                    _login.Show();
                    break;
            }
        }

        private void LoadCharts()
        {
            List<Ticket> ticketList = _ticket_Service.GetTickets();

            // chart day
            int openTicket = 0, closedTicket = 0, passedDeadlineTicket = 0;

            foreach (Ticket ticket in ticketList)
            {
                if (ticket.Company.Id == _CurrentUser.Company.Id)
                {
                    if ((ticket.CreatedAt.Date <= DateTime.Now.Date) && (ticket.Deadline.Date > DateTime.Now.Date) && (ticket.Status == TicketStatus.Open))
                    {
                        openTicket++;
                    }
                    else if ((ticket.Deadline.Date < DateTime.Now.Date) && (ticket.Status == TicketStatus.Open))
                    {
                        passedDeadlineTicket++;
                    }
                    else if ((ticket.ClosedAt.Date == DateTime.Now.Date) && (ticket.Status == TicketStatus.Closed))
                    {
                        closedTicket++;
                    }
                }
            }

            double[] values = { closedTicket, openTicket, passedDeadlineTicket };
            string[] labels = { $"{closedTicket}\nClosed", $"{openTicket}\nOpen", $"{passedDeadlineTicket}\n       Past Deadline" };
            var PlotDayPie = formsPlotDayPie.Plot.AddPie(values);
            PlotDayPie.SliceLabels = labels;
            PlotDayPie.ShowLabels = true;
            PlotDayPie.Explode = true;
            PlotDayPie.SliceFillColors = new Color[] { Color.Green, Color.SteelBlue, Color.DarkOrange };
            formsPlotDayPie.Render();


            // chart week
            int mondayAmountTicket = 0, tuesdayAmountTicket = 0, wednesdayAmountTicket = 0, thursdayAmountTicket = 0, 
                fridayAmountTicket = 0, saturdayAmountTicket = 0, sundayAmountTicket = 0;

            foreach (Ticket ticket in ticketList)
            {
                if ((GetWeekNumber(ticket.CreatedAt.Date) == GetWeekNumber(DateTime.Now.Date)) && (ticket.Company.Id == _CurrentUser.Company.Id))
                {
                    switch (ticket.CreatedAt.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            mondayAmountTicket++;
                            break;
                        case DayOfWeek.Tuesday:
                            tuesdayAmountTicket++;
                            break;
                        case DayOfWeek.Wednesday:
                            wednesdayAmountTicket++;
                            break;
                        case DayOfWeek.Thursday:
                            thursdayAmountTicket++;
                            break;
                        case DayOfWeek.Friday:
                            fridayAmountTicket++;
                            break;
                        case DayOfWeek.Saturday:
                            saturdayAmountTicket++;
                            break;
                        case DayOfWeek.Sunday:
                            sundayAmountTicket++;
                            break;
                    }
                }
            }

            double[] valuess = { mondayAmountTicket, tuesdayAmountTicket, wednesdayAmountTicket, thursdayAmountTicket, fridayAmountTicket, saturdayAmountTicket, sundayAmountTicket };
            double[] positionss = { 0, 1, 2, 3, 4, 5, 6 };
            string[] labelss = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            chartWeek.Plot.AddBar(valuess, positionss, Color.SteelBlue);
            chartWeek.Plot.XTicks(positionss, labelss);
            chartWeek.Plot.SetAxisLimits(yMin: 0);
            chartWeek.BackColor = Color.White;
            chartWeek.Plot.SetAxisLimits(yMin: 0);

            chartWeek.Render();
        }

        private static int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
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

        private void KMBTN_Click(object sender, EventArgs e)
        {
            MenuSwitch("KeyManagement");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using MongoDB.Bson;
using NoDeskLogic;
using NoDeskModels;
namespace Test_Terminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        private static int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        public void Start()
        {
            //KeyCheck keyCheck = new KeyCheck();
            // string encrypt = keyCheck.CreateActivationKey("test");

            //Console.WriteLine(encrypt);

            ////Console.ReadKey();
            ////Console.WriteLine();

            ////string decrypt = test.Decrypt(encrypt);
            ////Console.WriteLine(decrypt);
            ///



            Ticket_Service ticket_Service = new Ticket_Service();

            int openticket = 0;
            int closedticket = 0;
            int passeddeadlineticket = 0;
        

            List<Ticket> ticketList = ticket_Service.GetTickets();

            foreach (Ticket ticket in ticketList)
            {
                if((ticket.CreatedAt.Date <= DateTime.Now.Date) && (ticket.Deadline.Date > DateTime.Now.Date) && (ticket.Status == TicketStatus.Open))
                {
                    openticket++;
                }
                else if ((ticket.Deadline.Date < DateTime.Now.Date) && (ticket.Status == TicketStatus.Open))
                {
                    passeddeadlineticket++;
                }
                else if ((ticket.ClosedAt.Date == DateTime.Now.Date) && (ticket.Status == TicketStatus.Closed))
                {
                    closedticket++;
                }
            }

            Console.WriteLine($"Open Tickets: {openticket}");
            Console.WriteLine();
            Console.WriteLine($"Closed Tickets: {closedticket}");
            Console.WriteLine();
            Console.WriteLine($"Tickets passed deadline: {passeddeadlineticket}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

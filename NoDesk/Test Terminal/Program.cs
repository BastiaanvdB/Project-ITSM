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

            int mondayAmountTicket = 0;
            int tuesdayAmountTicket = 0;
            int wednesdayAmountTicket = 0;
            int thursdayAmountTicket = 0;
            int fridayAmountTicket = 0;
            int saturdayAmountTicket = 0;
            int sundayAmountTicket = 0;

            List<Ticket> ticketList = ticket_Service.GetTickets();
            foreach (Ticket ticket in ticketList)
            {


                if(GetWeekNumber(ticket.CreatedAt.Date) == GetWeekNumber(DateTime.Now.Date))
                {
                    switch(ticket.CreatedAt.DayOfWeek)
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
            Console.WriteLine($"Monday: {mondayAmountTicket}");
            Console.WriteLine();
            Console.WriteLine($"Tuesday: {tuesdayAmountTicket}");
            Console.WriteLine();
            Console.WriteLine($"Wednesday: {wednesdayAmountTicket}");
            Console.WriteLine();
            Console.WriteLine($"Thursday: {thursdayAmountTicket}");
            Console.WriteLine();
            Console.WriteLine($"Friday: {fridayAmountTicket}");
            Console.WriteLine();
            Console.WriteLine($"Saturday: {saturdayAmountTicket}");
            Console.WriteLine();
            Console.WriteLine($"Sunday: {sundayAmountTicket}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

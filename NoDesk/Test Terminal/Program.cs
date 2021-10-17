using System;
using System.Collections.Generic;
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

            int openCount = 0;
            int closedCount = 0;
            int delayedCount = 0;

            List<Ticket> ticketList = ticket_Service.GetTickets();
            foreach (Ticket ticket in ticketList)
            {
                if((ticket.CreatedAt.Date == DateTime.Now.Date) && (ticket.Status == TicketStatus.Open))
                {
                    openCount++;
                }
                else if ((ticket.CreatedAt.Date == DateTime.Now.Date) && (ticket.Status == TicketStatus.Closed))
                {
                    closedCount++;
                }
                else if ((ticket.CreatedAt.Date < DateTime.Now.Date) && (ticket.Status == TicketStatus.Open))
                {
                    delayedCount++;
                }
            }
            Console.WriteLine($"Open tickets: {openCount}");
            Console.WriteLine($"closed tickets: {closedCount}");
            Console.WriteLine($"delayed tickets: {delayedCount}");

            Console.ReadKey();
        }
    }
}

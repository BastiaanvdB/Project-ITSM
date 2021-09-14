using System;
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
            // test
            Ticket_Service ticket_Service = new Ticket_Service();
            var recs = ticket_Service.GetTickets();

            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.Id} {rec.Subject} {rec.Text}");
            }

            Console.ReadKey();
        }
    }
}

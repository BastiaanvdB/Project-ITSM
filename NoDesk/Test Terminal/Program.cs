using System;
using NoDeskDAL;
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
            Ticket_DAL ticket_DAL = new Ticket_DAL();
            
            var recs = ticket_DAL.GetTickets();

            foreach (var rec in recs)
            {
                Console.WriteLine($"{rec.Id} {rec.Subject} {rec.Text}");
            }

            Console.ReadKey();
        }
    }
}

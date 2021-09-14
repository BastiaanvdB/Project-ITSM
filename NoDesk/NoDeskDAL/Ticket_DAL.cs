using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using NoDeskModels;
namespace NoDeskDAL
{
    public class Ticket_DAL : Base
    {
        public void InsertTicket(Ticket ticket)
        {
            InsertRecord("Tickets", ticket);
        }

        public List<Ticket> GetTickets()
        {
            return LoadRecords<Ticket>("Tickets");
        }

        public void UpdateTicket(Ticket ticket)
        {
            var update = Builders<Ticket>.Update
                .Set(P => P.Subject, ticket.Subject)
                .Set(P => P.Text, ticket.Text);
            UpdateRecordById("Tickets", ticket.Id, update);
        }

        public void DeleteTicketById(Ticket ticket)
        {
            DeleteRecordById<Ticket>("Tickets", ticket.Id);
        }
    }
}

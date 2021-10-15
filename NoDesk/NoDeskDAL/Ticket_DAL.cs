using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
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

        public void UpdateTicketUser(Ticket ticket)
        {
            var update = Builders<Ticket>.Update
                .Set(P => P.Creator, ticket.Creator);
            UpdateRecordById("Tickets", ticket.Id, update);
        }

        public void UpdateTicketStatus(Ticket ticket)
        {
            var update = Builders<Ticket>.Update
                .Set(P => P.Status, ticket.Status);
            UpdateRecordById("Tickets", ticket.Id, update);
        }

        public void DeleteTicketById(Ticket ticket)
        {
            DeleteRecordById<Ticket>("Tickets", ticket.Id);
        }
        public Ticket GetTicketById(ObjectId Id)
        {
            return LoadRecordById<Ticket>("Tickets", Id);
        }
    }
}

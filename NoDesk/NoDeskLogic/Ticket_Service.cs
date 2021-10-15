using System;
using System.Collections.Generic;
using MongoDB.Bson;
using NoDeskDAL;
using NoDeskModels;
namespace NoDeskLogic
{
    public class Ticket_Service
    {
        private Ticket_DAL _Ticket_DAL;
        public Ticket_Service()
        {
            _Ticket_DAL = new Ticket_DAL();
        }

        public void InsertTicket(Ticket ticket)
        {
            _Ticket_DAL.InsertTicket(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return _Ticket_DAL.GetTickets();
        }

        public void UpdateTicketUser(Ticket ticket)
        {
            _Ticket_DAL.UpdateTicketUser(ticket);
        }
        public void UpdateTicketStatus(Ticket ticket)
        {
            _Ticket_DAL.UpdateTicketStatus(ticket);
        }

        public void DeleteTicket(Ticket ticket)
        {
            _Ticket_DAL.DeleteTicketById(ticket);
        }

        public Ticket GetTicketById(ObjectId Id)
        {
            return _Ticket_DAL.GetTicketById(Id);
        }
    }
}

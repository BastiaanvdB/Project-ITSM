using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace NoDeskModels
{
    public class Ticket
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Subject")]
        public string Subject { get; set; }
        [BsonElement("Text")]
        public string Text { get; set; }
        [BsonElement("TicketCreatedBy")]
        public User Creator { get; set; }
        [BsonElement("TicketStatus")]
        public TicketStatus Status { get; set; }
        [BsonElement("TicketCreatedAt")]
        public DateTime CreatedAt { get; set; }
        [BsonElement("TicketClosedAt")]
        public DateTime ClosedAt { get; set; }
        [BsonElement("User")]

        public string User { get; set; }
        [BsonElement("Date")]
        public DateTime Date { get; set; }
        [BsonElement("Type")]
        public TypeIncident Type { get; set; }
        [BsonElement("Priority")]
        public Priority Priority { get; set; }
        [BsonElement("Deadline")]
        public DateTime Deadline { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
    }
}

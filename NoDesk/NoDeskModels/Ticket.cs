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
        public string Creator { get; set; }
        [BsonElement("Company")]
        public Company Company { get; set; }
        [BsonElement("Status")]
        public TicketStatus Status { get; set; }
        [BsonElement("TicketCreatedAt")]
        public DateTime CreatedAt { get; set; }
        [BsonElement("Deadline")]
        public DateTime Deadline { get; set; }
        [BsonElement("TicketClosedAt")]
        public DateTime ClosedAt { get; set; }
        [BsonElement("Type")]
        public TypeIncident Type { get; set; }
        [BsonElement("Priority")]
        public Priority Priority { get; set; }
    }
}

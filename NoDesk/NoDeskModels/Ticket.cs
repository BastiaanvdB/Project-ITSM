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
        [BsonElement("TicketCreatedAt")]
        public DateTime CreatedAt { get; set; }
        [BsonElement("TicketClosedAt")]
        public DateTime ClosedAt { get; set; }
    }
}

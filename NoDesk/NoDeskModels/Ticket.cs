using MongoDB.Bson.Serialization.Attributes;
using System;

namespace NoDeskModels
{
    public class Ticket
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("Subject")]
        public string Subject { get; set; }
        [BsonElement("Text")]
        public string Text { get; set; }
    }
}

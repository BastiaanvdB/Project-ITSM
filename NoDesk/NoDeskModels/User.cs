using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDeskModels
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Firstname")]
        public string Firstname { get; set; }
        [BsonElement("Lastname")]
        public string Lastname { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        [BsonElement("Company")]
        public Company Company { get; set; }
        [BsonElement("Role")]
        public Roles Role { get; set; }
        [BsonElement("InvitationKey")]
        public string productkey { get; set; }
    }
}

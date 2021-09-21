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
        public Guid Id { get; set; }
        [BsonElement("Firstname")]
        public string Firstname { get; set; }
        [BsonElement("Lastname")]
        public string Lastname { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        [BsonElement("Company")]
        public string Company { get; set; }
        [BsonElement("Role")]
        public Roles Role { get; set; }
        [BsonElement("ActivationCode")]
        public string ActivationCode { get; set; }
        [BsonElement("InviteCode")]
        public string InviteCode { get; set; }
    }
}

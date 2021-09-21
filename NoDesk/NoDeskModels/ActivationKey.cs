using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDeskModels
{
    public class ActivationKey
    {
        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("InvitationKeys")]
        public string[] InvitationKeys { get; set; }
    }
}

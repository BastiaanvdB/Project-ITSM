using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDeskModels
{
    public class Company
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("CompanyName")]
        public string CompanyName { get; set; }
        [BsonElement("ActivationKey")]
        public string ActivationKey { get; set; }
    }
}

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
        public Guid Id { get; set; }
        [BsonElement("Company")]
        public string CompanyName { get; set; }
        [BsonElement("ActivationKey")]
        public ActivationKey ActivationKey { get; set; }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDeskModels
{
    public class InvitationKey
    {
        [BsonId]
        public ObjectId Key { get; set; }
        public ObjectId ActivationKey { get; set; }
        public ObjectId CompanyId { get; set; }
        public Boolean UsedStatus { get; set; }
    }
}

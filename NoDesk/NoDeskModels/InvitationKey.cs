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
        public Guid Key { get; set; }
        public Guid CompanyId { get; set; }
    }
}

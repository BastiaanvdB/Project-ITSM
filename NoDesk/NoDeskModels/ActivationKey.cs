﻿using MongoDB.Bson.Serialization.Attributes;
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
        public Guid Key { get; set; }
        [BsonElement("InvitationKeys")]
        public InvitationKey[] InvitationKeys { get; set; }
    }
}

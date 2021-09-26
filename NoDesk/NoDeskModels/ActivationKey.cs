﻿using MongoDB.Bson;
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
        public ObjectId Key { get; set; }
        [BsonElement("UsedStatus")]
        public Boolean UsedStatus { get; set; }
    }
}

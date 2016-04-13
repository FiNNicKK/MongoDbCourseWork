﻿using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbApplication.Structure
{
    public class User
    {
        [BsonId]
        public ObjectId id { get; set; }
        public string name { get; set; }
        public string email { get; set; }    
        public string password { get; set; }
    }
}
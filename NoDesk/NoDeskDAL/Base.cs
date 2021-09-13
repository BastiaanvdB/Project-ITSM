﻿using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace NoDeskDAL
{
    public abstract class Base
    {
        private IMongoDatabase db;
        public Base()
        {
            var client = new MongoClient("mongodb+srv://bastiaan:2404tr2404tr@nodesk.s4ou6.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            this.db = client.GetDatabase("NoDesk");
        }

        protected void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        protected List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        protected T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }

        protected void UpdateRecordById<T>(string table, Guid id, UpdateDefinition<T> Record)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);
            collection.UpdateOne(filter, Record, new UpdateOptions() { IsUpsert = true });
        }

        protected void DeleteRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}

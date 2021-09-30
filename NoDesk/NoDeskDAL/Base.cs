using MongoDB.Bson;
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
            var client = new MongoClient("mongodb+srv://NoDesk:mjhq0tKtOM8CKlRR@nodesk.s4ou6.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
            this.db = client.GetDatabase("NoDesk");
        }

        // Insert Records
        protected void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        // Get records
        protected List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        //Get all records without mapping them to an object
        public List<BsonDocument> LoadRecordsNoMap(string table)
        {
            var collection = db.GetCollection<BsonDocument>(table);

            return collection.Find(new BsonDocument()).ToList();
        }

        // Get specific record by id
        protected T LoadRecordById<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }

        // get specific record by field
        protected T LoadRecordByField<T>(string table, string field, string data)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq(field, data);
            return collection.Find(filter).First();
        }
       
        // Update specific record by id
        protected void UpdateRecordById<T>(string table, ObjectId id, UpdateDefinition<T> Record)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);
            collection.UpdateOne(filter, Record, new UpdateOptions() { IsUpsert = true });
        }

        // Delete specific record by id
        protected void DeleteRecordById<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}

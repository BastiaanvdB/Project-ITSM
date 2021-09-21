using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;


namespace NoDeskModels
{
    public class User
    {
        public User(Guid Id, string FirstName, string LastName, string Job)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Job = Job;
        }


        [BsonId]
        public Guid Id { get; set; }
        [BsonElement("Id")]
        public string FirstName { get; set; }
        [BsonElement("FirstName")]

        public string LastName { get; set; }
        [BsonElement("LastName")]

        public string Job { get; set; }
        [BsonElement("Job")]

        public string Text { get; set; }

    }
}

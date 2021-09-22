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
        public User(int Id, string FirstName, string LastName, string Job, string Department)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Job = Job;
            this.Department = Department;
        }
       
        public int Id { get; set; }     
        public string FirstName { get; set; }       
        public string LastName { get; set; }       
        public string Job { get; set; }
        public string Department { get; set; }

    }
}

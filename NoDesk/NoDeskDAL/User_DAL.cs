using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using NoDeskModels;

namespace NoDeskDAL
{
    public class User_DAL : Base
    {
        public void DB_AddUser(User user)
        {
            InsertRecord("Users", user);
        }

        public List<User> DB_GetUsers()
        {
            return LoadRecords<User>("Users");
        }

        public void DB_UpdateUser(User user)
        {
            var update = Builders<User>.Update
                .Set(P => P.FirstName, user.FirstName)
                .Set(P => P.LastName, user.LastName)
                .Set(P => P.Job, user.Job);
            UpdateRecordById("Users", user.Id, update);
        }

        public void DB_DeleteUserOnId(User user)
        {
            DeleteRecordById<User>("Users", user.Id);
        }
    }
}

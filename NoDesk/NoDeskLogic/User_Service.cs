using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoDeskModels;
using MongoDB.Driver;
using MongoDB.Bson;
using NoDeskDAL;
namespace NoDeskLogic
{
    public class User_Service
    {
        private User_DAL _User_DAL;
        public User_Service()
        {
            _User_DAL = new User_DAL();
        }

        public void InsertUser(User user)
        {
            _User_DAL.InsertUser(user);
        }

        public List<User> GetUsers()
        {
            return _User_DAL.DB_GetUsers();
        }

        public List<BsonDocument> GetUsersNoMap()
        {
            return _User_DAL.DB_GetUsersNoMap();
        }

        public List<User> LoadUsersByCompanyName(string companyName)
        {
            return _User_DAL.LoadUsersByCompanyName(companyName);
        }

        public User CheckUserLogin(LoginAttempt login)
        {
            return _User_DAL.CheckUserLogin(login);
        }

        public User GetUserByKey(string key)
        {
            return _User_DAL.GetUserByKey(key);
        }

        public void UpdateUser(User user)
        {
            _User_DAL.UpdateUser(user);
        }

        public void DeleteUserById(User user)
        {
            _User_DAL.DeleteUserById(user);
        }

        public User GetUserById(ObjectId Id)
        {
            return _User_DAL.GetUserById(Id);
        }
    }
}

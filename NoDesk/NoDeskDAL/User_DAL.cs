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
        public void InsertUser(User user)
        {
            InsertRecord("Users", user);
        }

        public List<User> GetUsers()
        {
            return LoadRecords<User>("Users");
        }

        public void UpdateUser(User user)
        {
            var update = Builders<User>.Update
                .Set(P => P.Firstname, user.Firstname)
                .Set(P => P.Lastname, user.Lastname)
                .Set(P => P.Email, user.Email)
                .Set(P => P.Password, user.Password)
                .Set(P => P.Company, user.Company)
                .Set(P => P.Role, user.Role)
                .Set(P => P.ActivationKey, user.ActivationKey);
            UpdateRecordById("Users", user.Id, update);
        }

        public User CheckUserLogin(LoginAttempt login)
        {
            Encryption encryption = new Encryption();
            User user;
            try
            {
                user = LoadRecordByField<User>("Users", "Email", login.Email);
                if (encryption.Decrypt(user.Password) == login.Password)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public User GetUserByKey(string key)
        {
            return LoadRecordByField<User>("Users", "ActivationKey", key);
        }

        public List<User> LoadUsersByCompanyName(string companyName)
        {
            return LoadRecordsByField<User>("Users", "Company.CompanyName", companyName);
        }

        public void DeleteUserById(User user)
        {
            DeleteRecordById<User>("Users", user.Id);
        }
    }
}

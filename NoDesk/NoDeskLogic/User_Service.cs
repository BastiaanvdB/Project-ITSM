using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoDeskModels;
using NoDeskDAL;

namespace NoDeskLogic
{
    public class User_Service
    {
        User_DAL UserDAL;

        public User_Service()
        {
            UserDAL = new User_DAL();
        }

        public void AddUser(User user)
        {
            UserDAL.DB_AddUser(user);
        }

        public List<User> GetUsers()
        {
            return UserDAL.DB_GetUsers();
        }

        public void UpdateUser(User user)
        {
            UserDAL.DB_UpdateUser(user);
        }

        public void DeleteUserOnId(User user)
        {
            UserDAL.DB_DeleteUserOnId(user);
        }
    }
}

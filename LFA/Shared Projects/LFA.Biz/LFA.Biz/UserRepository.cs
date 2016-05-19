using LFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Biz
{
    /// <summary>
    /// User repository to get all data related to users
    /// </summary>
    public class UserRepository
    {
        private static List<User> _lstUsers;

        static UserRepository()
        {
            User u1 = new User { UserID = 1, UserName = "user1", Password = "passowrd" };
            User u2 = new User { UserID = 2, UserName = "user2", Password = "passowrd" };

            List<User> lstUsers = new List<User>();
            lstUsers.Add(u1);
            lstUsers.Add(u2);

            for (int i = 3; i < 10; i++)
            {
                User u = new User { UserID = i, UserName = "user" + i, Password = "password" };
                lstUsers.Add(u);
            }
            _lstUsers = lstUsers;
        }

        public List<User> GetAll()
        {
            return _lstUsers;
        }

        public void Add(User user)
        {
            _lstUsers.Add(user);
        }

        public void Delete(User user)
        {
            _lstUsers.Remove(user);
        }


    }
}

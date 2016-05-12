using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LFA.Data
{
    public static class MyDataExtension
    {
        public static bool IsAdmin(this LFAUser user)
        {
            return (user.UserName == "admin" && user.Password == "password");
        }

        public static string GetUserRole(this LFAUser user)
        {
            string strRole = "Guest";
            if ((user.UserName == "admin" && user.Password == "password"))
                strRole = "admin";
            else if ((user.UserName == "user" && user.Password == "password"))
                strRole = "user";
            return strRole;
        }
    }
}

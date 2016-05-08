using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Console.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Authenticate();

            

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        private static void Authenticate()
        {
            Console.WriteLine("Welcome to LFA console management system !!");
            string strCondition = "n";

            Console.Write("User Name: ");
            string strUserName = Console.ReadLine();

            Console.Write("Password:");
            string strPassword = Console.ReadLine();

            if ((strUserName == "admin") && (strPassword == "password"))
            {
                Console.WriteLine("welcome {0} you are logged in as admin", strUserName);
            }
            else if ((strUserName == "user") && (strPassword == "password"))
            {
                Console.WriteLine("welcome " + strUserName + " are logged in as user");
            }
            else
            {
                Console.WriteLine("Invalid username or password");
                Console.WriteLine("Do you want to continuee? Y/N");
                strCondition = Console.ReadLine();
            }
        }

        //private static void LoginUser()
        //{
        //    Console.WriteLine("Welcome to LFA console management system !!");
        //    string strCondition = "n";
        //    do
        //    {
        //        strCondition = AuthenticateUser(strCondition);

        //    } while (strCondition.ToLower() != "N");
        //}

        //private static string AuthenticateUser(string strCondition)
        //{
        //    Console.Write("User Name: ");
        //    string strUserName = Console.ReadLine();

        //    Console.Write("Password:");
        //    string strPassword = Console.ReadLine();

        //    if ((strUserName == "admin") && (strPassword == "password"))
        //    {
        //        Console.WriteLine("welcome {0} you are logged in as admin", strUserName);
        //    }
        //    else if ((strUserName == "user") && (strPassword == "password"))
        //    {
        //        Console.WriteLine("welcome " + strUserName + " are logged in as user");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid username or password");
        //        Console.WriteLine("Do you want to continuee? Y/N");
        //        strCondition = Console.ReadLine();
        //    }
        //    return strCondition;
        //}
    }
}

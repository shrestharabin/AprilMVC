using LFA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LFA.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            Console.WriteLine("Welcome to LFA user management system");
            Console.Write("User Name:");
            string strUserName = Console.ReadLine();
            Console.Write("Password:");
            string strPassword = Console.ReadLine();

            User objUser = new User(strUserName,strPassword);
            //objUser.UserName = strUserName;
            //objUser.Password = strPassword;

            objUser.Authenticate();

            var isLoggedIn = objUser.Authenticate(strUserName, strPassword);

            Console.WriteLine(isLoggedIn);

            Console.ReadLine();
            Console.WriteLine("User name of objuser =" + objUser.UserName);
            //Console.WriteLine("strPassword value is {0}",strPassword);
            //Console.WriteLine("value of count is :- " + count);

            int copyOfCount = count;

            var copyOfCount1 = copyOfCount;

            Console.WriteLine("value of count is :- " + count);
            Console.WriteLine("copyOfCount of count is :- " + copyOfCount);
            copyOfCount++;
            copyOfCount = copyOfCount + 1;
            Console.WriteLine("copyOfCount of count is :- " + copyOfCount);

            User objUserCopy = objUser;
            objUserCopy.UserName = "New User";

            Console.WriteLine("User name of objuser =" + objUser.UserName);
            Console.WriteLine("User name of objUserCopy =" + objUserCopy.UserName);

            //Console.WriteLine(objUser.Password);
            //User newUser = objUser;
            //newUser.Password = "changed in both";
            //Console.WriteLine(objUser.Password);



            //User objUser1 = new User { UserID = 2, UserName = "user", Password = "password" };
            //User objUser2 = new User();             

            //Console.WriteLine(objUser.UserName);
            //Console.WriteLine(objUser.Password);


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

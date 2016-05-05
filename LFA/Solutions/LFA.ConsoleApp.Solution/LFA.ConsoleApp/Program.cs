using LFA.Common;
using LFA.Data;
using System;
using System.Collections;
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


            Base objBaseS = new Base();
            objBaseS.Display();
            DerivedOverrite objDerivedOverrite = new DerivedOverrite();
            Base objBaseOverrite = (Base)objDerivedOverrite;
            objBaseOverrite.Display();
            DerivedOverride objDerived = new DerivedOverride();

            Base objBase = (Base)objDerived;
            objBase.Display();

            Console.ReadLine();

            Base[] arrUser = new Base[] { objBaseS, objDerivedOverrite, objDerived };
            List<Base> lstBases = new List<Base> { objBaseS, objDerivedOverrite, objDerived };

            List<string> lstString = new List<string> { "One", "two" };

            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("string");
            arrList.Add(objDerived);

            foreach (var item in arrList)
            {

            }


            foreach (var item in arrUser)
            {
                item.Display();
            }

            for (int i = 0; i < arrUser.Length; i++)
            {
                arrUser[i].Display();
            }


            string[] arr = new string[] { "One", "Two", "Theree" };

            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


            int count = 1;
            //var strLog=LogService.Action("initalizing program...");
            //Console.WriteLine("Welcome to LFA user management system");
            //Console.Write("User Name:");
            //string strUserName = Console.ReadLine();
            //Console.Write("Password:");
            //string strPassword = Console.ReadLine();

            User objUser = new User();
            //objUser.FirstName = "Ravi";
            //objUser.LastName = "shrestha"; 

            if (new User().Authenticate())
            {//user is authenticatd returns true
                Console.WriteLine("you are authenticated");
            }
            else
            {
                Console.WriteLine("you are not authenticated");
            }

            bool isLoggedIn = objUser.Authenticate(userName: "admin");

            if (isLoggedIn == true)
            {
                Console.WriteLine("you are authenticated");
            }
            else
            {
                Console.WriteLine("you are not authenticated");
            }

            var isUserValid = new User().Authenticate("user", "password");


            objUser.Authenticate(userName: "admin");
            objUser.Authenticate("anonymous", "diffpassword");

            //var isLoggedIn = objUser.Authenticate(strUserName, strPassword);
            //Console.WriteLine(isLoggedIn);

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

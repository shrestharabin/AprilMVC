using LFA.Biz;
using LFA.Common;
using LFA.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace LFA.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection con = new OleDbConnection();


            SqlConnection conn = new SqlConnection("Password=system;Persist Security Info=True;User ID=sa;Initial Catalog=LFABlog;Data Source=192.168.1.27;");
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM dbo.Roles";
            cmd.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {               
                Console.WriteLine(dr["RoleName"]);
            }
            dr.Close();
            conn.Close();

            Console.Read();

            var userRepo = new UserRepository();           

            List<User> lstUsers = userRepo.GetAll();

            foreach (var item in lstUsers)
            {
                Console.WriteLine("User ID: " +item.UserID+ " user name: " +item.UserName);
            }

            userRepo.Add(new User {UserID=10,UserName="user10",Password="password" });

            List<User> newLIst = userRepo.GetAll();

            List<int> lstInt = new List<int>();
            lstInt.Add(1);

            lstInt.First();
            var first=lstInt[0];


            var userToRemove = newLIst.Where(x => x.UserID == 5).ToList();

            string[] arrStr = new string[] { "a", "b" };

            

            Console.ReadLine();


            //var lstUSers = new LFAUser().GetAll();
            //new LFAUser().Remove(lstUSers.First());

            //var final = new LFAUser().GetAll();

            //new LFAUser().Add(new LFAUser {UserID=2,UserName="user-03",Password="password" });

            //var lstAfterAdd = new LFAUser().GetAll();
            

            int y = new int();
            var result = y.Multply();

            var mul = y * y;


            StringBuilder sb = new StringBuilder();
            sb.Append("First Value");
            sb.Append("second");

            var finalString = sb.ToString();
            string str1 = "First Value";
            str1 += "added";

            string str1Copy = str1;
            str1Copy = "new value";

            int a = 2;
            //var result = a.Multply();

            string strValue = "a";
            int z = 0;
            int.TryParse(strValue, out z);

            string strRole;
           
            LFAUser objUser1 = new LFAUser();
            objUser1.IsAdmin();

            objUser1.AuthOut(out strRole);

            var isValidobj = objUser1.Authenticate();
            objUser1.IsAdmin();
            var role = objUser1.GetUserRole();


            Console.ReadLine();

            BaseClass objBaseS = new BaseClass();
            objBaseS.Display();
            DerivedOverrite objDerivedOverrite = new DerivedOverrite();
            BaseClass objBaseOverrite = (BaseClass)objDerivedOverrite;
            objBaseOverrite.Display();
            DerivedOverride objDerived = new DerivedOverride();

            BaseClass objBase = (BaseClass)objDerived;
            objBase.Display();

            Console.ReadLine();

            BaseClass[] arrUser = new BaseClass[] { objBaseS, objDerivedOverrite, objDerived };
            List<BaseClass> lstBases = new List<BaseClass> { objBaseS, objDerivedOverrite, objDerived };

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

            LFAUser objUser = new LFAUser();
            //objUser.FirstName = "Ravi";
            //objUser.LastName = "shrestha"; 

            if (new LFAUser().Authenticate())
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

            var isUserValid = new LFAUser().Authenticate("user", "password");


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

            LFAUser objUserCopy = objUser;
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

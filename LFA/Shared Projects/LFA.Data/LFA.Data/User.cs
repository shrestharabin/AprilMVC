using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Data
{
    /// <summary>
    /// User class for storing username password.
    /// </summary>
    public partial class User
    {
        #region Private Members

        private int count;

        #endregion

        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        public User()
        {
            _password = "password";
            userName = "guest";
        }

        /// <summary>
        /// Create user with username and passowd
        /// </summary>
        /// <param name="userName">Provide user name </param>
        /// <param name="password">Provide password </param>
        public User(string userName, string password)
            : this()
        {
            UserName = userName;
            Password = password;
        }

        #endregion

        #region Public Members

        public int UserID { get; set; }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string FullName { get { return this.FirstName + " " + this.LastName; } }

        //public string FullName { get; set; }

        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}


        #endregion

        #region Public Methods



        //public void Authenticate()
        //{
        //    if ((UserName == "admin") && (Password == "password"))
        //    {
        //        Console.WriteLine("welcome {0} you are logged in as Administrator", this.FullName);
        //    }
        //    else if ((UserName == "user") && (Password == "password"))
        //    {
        //        Console.WriteLine("welcome {0} you are logged in as Normal User", UserName);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid login");
        //    }
        //}

        public bool Authenticate(string userName = "anonymous", string password = "password")
        {
            //return true;
            return (((userName == "admin") && (password == "password"))
                || (userName == "user") && (password == "password"));
        }

        public bool Authenticate(string userName)
        {
            return (((userName == "admin") && (Password == "password"))
                || (userName == "user") && (Password == "password"));
        }

        public bool Auth(ref string role,string userName = "anonymous", string password = "password")
        {
            string strRole = "Guest";
            if ((userName == "admin" && password == "password"))
                strRole = "admin";
            else if ((userName == "user" && password == "password"))
                strRole = "user";
            role = strRole;

            return strRole == "Guest" ? false : true;

        }

        public bool AuthOut(out string role, string userName = "anonymous", string password = "password")
        {
            string strRole = "Guest";
            if ((userName == "admin" && password == "password"))
                strRole = "admin";
            else if ((userName == "user" && password == "password"))
                strRole = "user";
            role = strRole;

            return strRole == "Guest" ? false : true;

        }

        public User GetUser(string userName = "anonymous", string password = "password")
        {
            //this.UserName = userName;
            //this.Password = Password;
            //return this;

            User objUser = new User { Password = password, UserName = userName };
            return objUser;

            //User objUser1 = new User();
            //objUser1.UserName = userName;
            //objUser1.Password = password;
            //return objUser;

        }



        #endregion

    }
}

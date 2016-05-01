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
    public class User
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

        #endregion

        #region Public Methods

        public void Authenticate()
        {
            if ((UserName == "admin") && (Password == "password"))
            {
                Console.WriteLine("welcome {0} you are logged in as Administrator", UserName);
            }
            else if ((UserName == "user") && (Password == "password"))
            {
                Console.WriteLine("welcome {0} you are logged in as Normal User", UserName);
            }
            else
            {
                Console.WriteLine("Invalid login");
            }
        }

        public bool Authenticate(string userName, string password)
        {
            return (((userName == "admin") && (password == "password"))
                || (userName == "user") && (password == "password"));

        }

        #endregion

    }
}

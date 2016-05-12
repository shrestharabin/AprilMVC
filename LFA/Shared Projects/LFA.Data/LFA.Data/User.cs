using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LFA.Data
{
    public class User :Base
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

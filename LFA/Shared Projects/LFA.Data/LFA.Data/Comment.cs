using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LFA.Data
{
    public class Comment:Base
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public int PostID { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LFA.Data
{
    public class Posts:Base
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LFA.Data
{
    public partial class LFAUser
    {
        public string FullName { get { return this.FirstName + " " + this.LastName; } }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTest.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public string Name { set; get; }
        public int Age { set; get; }

    }
}

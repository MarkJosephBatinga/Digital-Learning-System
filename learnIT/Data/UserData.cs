﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Data
{
    //user_table in the learnItDb
    public class UserData
    {
        public int id { get; set; }

        public string last_name { get; set; }
        public string first_name { get; set; }
        public string email { get; set; }
        public string user_password { get; set; }

    }
}
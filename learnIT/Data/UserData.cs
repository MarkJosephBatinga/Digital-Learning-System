using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Data
{
    //user_table in the learnItDb
    public class UserData
    {
        //name in this class needs to be the same in the user_table columns
        //database name = learnItDb
        //database table name = user_table
        public int id { get; set; }

        public string last_name { get; set; }
        public string first_name { get; set; }
        public string email { get; set; }
        public string user_password { get; set; }
        public string user_role { get; set; }

    }
}

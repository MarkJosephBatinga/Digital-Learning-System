using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Data
{
    //user_profile in the learnItDb
    class UserProfile
    {
        //name in this class needs to be the same in the user_profile columns
        //database name = learnItDb
        //database table name = user_profile
        public int user_id { get; set; }

        public string year_level { get; set; }
        public string birth_date { get; set; }
        public string gender { get; set; }
        public int phone { get; set; }
        public string add_street { get; set; }
        public string add_town { get; set; }
        public string add_province { get; set; }
        public int add_zipcode { get; set; }
        public int id { get; set; }
    }
}

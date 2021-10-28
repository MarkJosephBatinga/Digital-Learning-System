using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.SqlQueries
{
    class SendDataQuery
    {
        public static string SendDataQueryString(List<string> userData)
        {
            string last_name = userData[0];         //ValidData[0]
            string first_name = userData[1];        //ValidData[1]
            string email = userData[2];             //ValidData[2]
            string password = userData[3];          //ValidData[3]
            string role = userData[4];              //ValidData[4]
            return $"INSERT INTO user_table(last_name, first_name, email, user_password, user_role) VALUES('{last_name}','{first_name}','{email}', HASHBYTES('SHA2_512', '{password}'), '{role}');";
        }

        public static string SendDataProfileQuery(List<string> userProfile, List<int> userProfileInt, long Phone)
        {
            string year_level = userProfile[0];
            string birth_date = userProfile[1];
            string gender = userProfile[2];
            long phone = Phone;
            string add_street = userProfile[3];
            string add_town = userProfile[4];
            string add_province = userProfile[5];
            int id = userProfileInt[0];
            int add_zipcode = userProfileInt[1];
            

            return $"INSERT INTO user_profile(year_level, birth_date, gender, phone, add_street, add_town, add_province, add_zipcode, id) VALUES('{year_level}', '{birth_date}', '{gender}', {phone}, '{add_street}', '{add_town}', '{add_province}', {add_zipcode}, {id});";
        }

        public static string GetIdQuery(string email)
        {
            return $"SELECT id FROM user_table WHERE email = '{email}';";
        }

        public static string SearchEmail(string email)
        {
            return $"SELECT email FROM user_table WHERE email = '{email}';";
        }
    }
}

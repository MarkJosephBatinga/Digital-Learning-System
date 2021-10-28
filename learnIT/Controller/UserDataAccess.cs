using Dapper;
using learnIT.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using learnIT.SqlQueries;

namespace learnIT.Controller
{
    public class UserDataAccess
    {
        //Send the validated data from the database
        public void SendUserDataToDatabase(List<string> User)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserData>(SendDataQuery.SendDataQueryString(User)); 
                Console.WriteLine("Added Successfully");
            }
        }

        //Send the validated data from the database
        public void SendUserProfileToDatabase(List<string> UserProfile, List<int> UserProfileInt, long phone)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserData>(SendDataQuery.SendDataProfileQuery(UserProfile, UserProfileInt, phone));
                Console.WriteLine("Added Successfully");
            }
        }

        //Get the id of user from the database
        public List<UserData> GetUserId(string email)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                var output = conn.Query<UserData>(SendDataQuery.GetIdQuery(email)).ToList();
                return output;
            }
        }

        //Get the id of user from the database
        public List<UserData> SearchForEmail(string email)
        {
            List<UserData> searchedEmail = new List<UserData>();
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                searchedEmail = conn.Query<UserData>(SendDataQuery.SearchEmail(email)).ToList();
                return searchedEmail;
            }
        }
    }
}

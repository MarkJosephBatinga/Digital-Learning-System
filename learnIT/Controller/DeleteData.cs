using Dapper;
using learnIT.Data;
using learnIT.SqlQueries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Controller
{
    class DeleteData
    {
        //Delete User Data from table user_table
        public void DeleteUserData(int id)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserProfile>(DeleteQuery.DeleteUserData(id));
                Console.WriteLine("Update User Profile Successfull");
            }
        }

        //Delete User Profile from table user_profile
        public void DeleteUserProfile(int id)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserProfile>(DeleteQuery.DeleteUserProfile(id));
                Console.WriteLine("Update User Profile Successfull");
            }
        }

        //Delete User Class from table user_class
        public void DeleteUserClass(int id)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserProfile>(DeleteQuery.DeleteUserClass(id));
                Console.WriteLine("Update User Profile Successfull");
            }
        }
    }
}

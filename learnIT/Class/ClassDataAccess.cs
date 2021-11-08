using Dapper;
using learnIT.Controller;
using learnIT.Data;
using learnIT.SqlQueries;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Class
{
    class ClassDataAccess
    {
        //Update Profile in the User Profile
        public void CreateNewClass(int id, List<string> Class)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserClass>(ClassQuery.CreateNewClass(id, Class)).ToList();
                Console.WriteLine("Create Class Successful");
            }
        }
    }
}

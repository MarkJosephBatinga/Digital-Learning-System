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

namespace learnIT.Chat
{
    class ChatDataAccess
    {
        List<ChatData> ChatInfo = new List<ChatData>();

        //Update Profile in the User Profile
        public void AddNewMessage(int id, int classId, List<string> chatInfo)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<ChatData>(ChatQuery.AddMessage(id, classId, chatInfo)).ToList();
                Console.WriteLine("Message Successfully Added");
            }
        }

        public List<ChatData> GetAllMessage(int classId)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                ChatInfo = conn.Query<ChatData>(ChatQuery.GetMessage(classId)).ToList();
                Console.WriteLine("Update User Profile Successfull");
                return ChatInfo;
            }
        }
    }
}

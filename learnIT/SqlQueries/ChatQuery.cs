using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.SqlQueries
{
    class ChatQuery
    {
        public static string AddMessage(int id, int classId, List<string> chatInfo)
        {
            return $"INSERT INTO user_chat(class_id, users_id, curr_time, curr_date, user_message) VALUES( {classId}, {id}, '{chatInfo[2]}', '{chatInfo[1]}', '{chatInfo[0]}');";
        }

        public static string GetMessage(int classId)
        {
            return $"SELECT * FROM user_chat WHERE class_id = {classId};";
        }
    }
}

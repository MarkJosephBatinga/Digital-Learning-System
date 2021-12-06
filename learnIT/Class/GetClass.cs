using learnIT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Class
{
    class GetClass
    {
        ClassDataAccess DatabaseAccess = new ClassDataAccess();
        List<UserClass> ClassInfo = new List<UserClass>();
        // return the User in the user_table
        public Tuple<string, string, string, string, int> GetClassData(int id)
        {
            //store the returned id from GetUSerID method to the new list od UserData
            ClassInfo = DatabaseAccess.GetClass(id);
            //check if the list is not empty and return the id
            foreach (var data in ClassInfo)
            {
                var User = Tuple.Create(data.class_title, data.class_section, data.class_code, data.class_description, data.class_creator);
                return User;
            }
            //default value return 0;
            return null;
        }

        public int GetClassId(string classCode, int classId)
        {
            ClassInfo = DatabaseAccess.JoinClass(classCode, classId);
            foreach(var data in ClassInfo)
            {
                return data.class_id;
            }
            return 0;
        }
    }
}

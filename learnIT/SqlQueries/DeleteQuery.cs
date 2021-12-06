using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.SqlQueries
{
    class DeleteQuery
    {
        public static string DeleteUserData(int id)
        {
            return $"DELETE FROM user_table WHERE id = {id};";
        }

        public static string DeleteUserProfile(int id)
        {
            return $"DELETE FROM user_profile WHERE id = {id};";
        }

        public static string DeleteUserClass(int id)
        {
            return $"DELETE FROM user_class WHERE class_creator = {id};";
        }


        //Class Delete Query
        public static string DeleteStudentClass(int classId)
        {
            return $"DELETE FROM student_class WHERE class_id = {classId};";
        }

        public static string DeleteIndividualUserClass(int classId)
        {
            return $"DELETE FROM user_class WHERE class_id = {classId};";
        }

        public static string DeleteIndividualStudentClass(int classId)
        {
            return $"DELETE FROM student_class WHERE class_id = {classId};";
        }
    }
}

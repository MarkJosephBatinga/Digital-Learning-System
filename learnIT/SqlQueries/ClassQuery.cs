using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.SqlQueries
{
    class ClassQuery
    {
        public static string CreateNewClass(int id, List<string> Class)
        {
            string title = Class[0];
            string section = Class[1];
            string code = Class[2];
            string description = Class[3];
            return $"INSERT INTO user_class(class_title, class_section, class_code, class_description, class_creator) VALUES('{title}', '{section}', '{code}', '{description}', {id});";
        }

        public static string SelectAllClass(int id)
        {
            return $"SELECT * FROM user_class WHERE class_creator = {id};";
        }

        public static string GetClass(int id)
        {
            return $"SELECT * FROM user_class WHERE class_id = {id};";
        }

        public static string SearchClass(string classCode,int classId)
        {
            return $"SELECT * FROM user_class WHERE class_code = '{classCode}' AND class_id = {classId};";
        }

        public static string CreateStudentClass(int studentId, int classId)
        {
            return $"INSERT INTO student_class(student_id, class_id) VALUES({studentId}, {classId});";
        }

        public static string GetAllStudentClass(int studentId)
        {
            return $"SELECT * FROM student_class WHERE student_id = {studentId};";
        }

        public static string GetAllClassInfo(int classId)
        {
            return $"SELECT * FROM user_class WHERE class_id = {classId};";
        }

        public static string SelectAllStudentClass(int studentId)
        {
            return $"SELECT * FROM student_class WHERE student_id = {studentId};";
        }

        public static string UpdateClassData(int classId, List<string> ClassData)
        {
            var title = ClassData[0];
            var section = ClassData[1];
            var code = ClassData[2];
            var description = ClassData[3];

            return $"  UPDATE user_class SET class_title = '{title}', class_section = '{section}', class_code = '{code}', class_description = '{description}' WHERE class_id = {classId};";
        }
    }
}

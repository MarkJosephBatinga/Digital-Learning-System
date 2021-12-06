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
        //Create New Class 
        public void CreateNewClass(int id, List<string> Class)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserClass>(ClassQuery.CreateNewClass(id, Class)).ToList();
            }
        }

        //Select all Class made from the id
        public List<UserClass> SelectAllClass(int id)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                var AllClass = conn.Query<UserClass>(ClassQuery.SelectAllClass(id)).ToList();
                return AllClass;
            }
        }

        //Select all Student Class made from the id
        public List<StudentClass> SelectAllStudentClass(int id)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                var AllStudentClass = conn.Query<StudentClass>(ClassQuery.SelectAllStudentClass(id)).ToList();
                return AllStudentClass;
            }
        }

        //Get Class using class id form user_class
        public List<UserClass> GetClass(int id)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                var AllClass = conn.Query<UserClass>(ClassQuery.GetClass(id)).ToList();
                return AllClass;
            }
        }

        //Join Class
        public List<UserClass> JoinClass(string classCode, int classId)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                var Class = conn.Query<UserClass>(ClassQuery.SearchClass(classCode, classId)).ToList();
                return Class;
            }
        }

        //Get All Class info in user_class table
        public List<UserClass> GetClassInfo(int classId)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                var ClassInfo = conn.Query<UserClass>(ClassQuery.GetAllClassInfo(classId)).ToList();
                return ClassInfo;
            }
        }

        //Create New student_class Entry in student_class
        public void CreateStudentClass(int studentId, int classId)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<StudentClass>(ClassQuery.CreateStudentClass(studentId, classId)).ToList();
            }
        }

        //Get All Student Classes in student_class table
        public List<StudentClass> GetStudentClass(int studentId)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                var ClassInfo = conn.Query<StudentClass>(ClassQuery.GetAllStudentClass(studentId)).ToList();
                return ClassInfo;
            }
        }

        //Edit Class in user_class table
        public void EditClassData(int classId, List<string> ClassData)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserClass>(ClassQuery.UpdateClassData(classId, ClassData));
            }
        }

        //Unenroll Classes in student_class table
        public void UnenrollStudentClass(int classId)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<StudentClass>(DeleteQuery.DeleteStudentClass(classId));
            }
        }


        //Delete Classes in user_class table and student_class table using class id
        public void DeleteUserClass(int classId)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserClass>(DeleteQuery.DeleteIndividualUserClass(classId));
                conn.Query<StudentClass>(DeleteQuery.DeleteIndividualStudentClass(classId));
            }
        }
    }
}

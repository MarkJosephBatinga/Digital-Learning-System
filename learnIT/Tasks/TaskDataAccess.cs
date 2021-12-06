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

namespace learnIT.TasksForm
{
    class TaskDataAccess
    {
        List<UserTask> TaskInfo = new List<UserTask>();
        List<StudentClass> ClassInfo = new List<StudentClass>();
        List<StudentTask> StudentTaskInfo = new List<StudentTask>();

        //Add New Task
        public void CreateNewTask(int classId, List<string> TaskInfo)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserTask>(TaskQuery.CreateNewTask(classId, TaskInfo));
                Console.WriteLine("Create Task Sucessful");
            }
        }


        //Get All Task
        public List<UserTask> GetAllTask(int classId)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                TaskInfo = conn.Query<UserTask>(TaskQuery.GetAllTask(classId)).ToList();
                Console.WriteLine("Get all Task Sucessful");
                return TaskInfo;
            }
        }

        //Get All Task
        public List<UserTask> GetTask(int taskId)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                TaskInfo = conn.Query<UserTask>(TaskQuery.GetTask(taskId)).ToList();
                Console.WriteLine("Get all Task Sucessful");
                return TaskInfo;
            }
        }

        //Get All Student in Task
        public List<StudentClass> GetAllStudents(int classId)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                ClassInfo = conn.Query<StudentClass>(TaskQuery.GetAllStudents(classId)).ToList();
                Console.WriteLine("Get all Task Sucessful");
                return ClassInfo;
            }
        }

        //Get All Task Using ClassId
        public List<UserTask> GetTaskUsingClassId(int classId)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                TaskInfo = conn.Query<UserTask>(TaskQuery.GetTaskUsingClassId(classId)).ToList();
                Console.WriteLine("Get all Task Sucessful");
                return TaskInfo;
            }
        }

        //Insert Student Task inof
        public void CreateNewStudentTask(int taskId, int StudentClassId, List<string> StudentTaskInfo)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserTask>(TaskQuery.CreateNewStudentTask(taskId, StudentClassId, StudentTaskInfo)).ToList();
                Console.WriteLine("Add student SuccessFul");
            }
        }

        //Get Student Class Info
        public List<StudentClass> GetStudentClassInfo(int classId, int Id)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                ClassInfo = conn.Query<StudentClass>(TaskQuery.GetStudentClassInfo(classId, Id)).ToList();
                Console.WriteLine("Get all Task Sucessful");
                return ClassInfo;
            }
        }

        //Find Student Class Id
        public List<StudentTask> FindStudentTaskId(int taskId, int studentClassId)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                StudentTaskInfo = conn.Query<StudentTask>(TaskQuery.FindStudentTaskId(taskId, studentClassId)).ToList();
                Console.WriteLine("Get all Task Sucessful");
                return StudentTaskInfo;
            }
        }

        //Find Student Class Id
        public void SetStudentGrade(int taskId, int grade, int studentClassId)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                StudentTaskInfo = conn.Query<StudentTask>(TaskQuery.SetStudentGrade(taskId, grade, studentClassId)).ToList();
                Console.WriteLine("Set Grade Successful");
            }
        }

        //Displaying Students Tasks

        //Get All Student Class
        public List<StudentClass> GetStudentClasses(int studentId)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                ClassInfo = conn.Query<StudentClass>(TaskQuery.GetAllStudentClass(studentId)).ToList();
                Console.WriteLine("Get All Class Successful");
                return ClassInfo;
            }
        }
    }
}

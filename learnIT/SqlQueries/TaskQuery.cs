using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.SqlQueries
{
    class TaskQuery
    {
        public static string CreateNewTask(int classId, List<string> TaskInfo)
        {
            //cur_date
            string currDate = TaskInfo[0];
            //task_title
            string title = TaskInfo[1];
            //task_type
            string type = TaskInfo[2];
            //task_date
            string date = TaskInfo[3];
            //task_time
            string time = TaskInfo[4];
            //task_filename
            string filename = TaskInfo[5];
            //task_filepath
            string filepath = TaskInfo[6];
            //task_description
            string decription = TaskInfo[7];
            return $"INSERT INTO user_tasks(class_id, cur_date, task_title, task_type, task_date, task_time, task_filename, task_filepath, task_description) VALUES( {classId}, '{currDate}', '{title}', '{type}', '{date}', '{time}', '{filename}', '{filepath}', '{decription}');";
        }


        public static string GetAllTask(int classId)
        {
           return $"SELECT * FROM user_tasks WHERE class_id = {classId};";
        }

        public static string GetTask(int taskId)
        {
            return $"SELECT * FROM user_tasks WHERE task_id = {taskId};";
        }

        public static string GetAllStudents(int classId)
        {
            return $"SELECT * FROM student_class WHERE class_id = {classId};";
        }

        public static string GetTaskUsingClassId(int classId)
        {
            return $"SELECT * FROM user_tasks WHERE class_id = {classId};";
        }

        public static string CreateNewStudentTask(int taskId, int StudentClassId, List<string> StudentTaskInfo)
        {
            //student_pass
            string isPass = StudentTaskInfo[0];
            //date_passed
            string currDate = StudentTaskInfo[1];
            //student pdf name
            string pdfName = StudentTaskInfo[2];
            //pdf_path
            string pdfPath = StudentTaskInfo[3];
            return $"INSERT INTO student_task(student_class_id, student_pass, date_passed, pdf_name, pdf_path, user_task_id) VALUES( {StudentClassId}, '{isPass}', '{currDate}', '{pdfName}', '{pdfPath}', {taskId});";
        }

        public static string GetStudentClassInfo(int classId, int Id)
        {
            return $"SELECT * FROM student_class WHERE class_id = {classId} and student_id = {Id};";
        }

        public static string FindStudentTaskId(int taskId, int studentTaskId)
        {
            return $"SELECT * FROM student_task WHERE student_class_id = {studentTaskId} and user_task_id={taskId};";
        }

        public static string SetStudentGrade(int taskId, int Grade, int studentClassId)
        {
            return $"UPDATE student_task SET student_grade={Grade} WHERE student_class_id={studentClassId} and user_task_id={taskId};;";
        }


        //Displaying Tasks
        //Get All Class of Student
        public static string GetAllStudentClass(int studentId)
        {
            return $"SELECT * FROM student_class WHERE student_id = {studentId};";
        }
    }
}

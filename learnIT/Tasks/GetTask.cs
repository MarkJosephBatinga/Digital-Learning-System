using learnIT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.TasksForm
{
    class GetTask
    {
        TaskDataAccess TaskAccess = new TaskDataAccess();
        List<StudentClass> ClassInfos = new List<StudentClass>();
        List<UserTask> TaskInfos = new List<UserTask>();
        List<StudentClass> AllStudents = new List<StudentClass>();
        List<StudentTask> StudentTaskInfos = new List<StudentTask>();

        public List<UserTask> GetTasks(int classId)
        {
            TaskInfos = TaskAccess.GetAllTask(classId);
            return TaskInfos;
        }

        public UserTask GetSingleTask(int taskId)
        {
            TaskInfos = TaskAccess.GetTask(taskId);
            foreach(UserTask TaskInfo in TaskInfos)
            {
                return TaskInfo;
            }
            return null;
        }

        public List<UserTask> GetTaskUsingClassId(int classId)
        {
            TaskInfos = TaskAccess.GetTaskUsingClassId(classId);
            if (TaskInfos != null)
            {
                return TaskInfos;
            }
            else
            {
                return null;
            }
            
        }

        public List<StudentClass> GetAllStudents(int classId)
        {
            AllStudents = TaskAccess.GetAllStudents(classId);
            return AllStudents;
        }

        public StudentClass GetStudentClassId(int classId, int Id)
        {
            ClassInfos = TaskAccess.GetStudentClassInfo(classId, Id);
            foreach (StudentClass ClassInfo in ClassInfos)
            {
                return ClassInfo;
            }
            return null;

        }

        public StudentTask GetStudentTaskId(int taskId, int studentTaskId)
        {
            StudentTaskInfos = TaskAccess.FindStudentTaskId(taskId, studentTaskId);
            foreach (StudentTask StudentTaskInfo in StudentTaskInfos)
            {
                return StudentTaskInfo;
            }
            return null;

        }


        public bool TaskPassed(int taskId, int studentTaskId)
        {
            StudentTaskInfos = TaskAccess.FindStudentTaskId(taskId, studentTaskId);
            foreach (StudentTask StudentTaskInfo in StudentTaskInfos)
            {
                return true;
            }
            return false;

        }
    }
}

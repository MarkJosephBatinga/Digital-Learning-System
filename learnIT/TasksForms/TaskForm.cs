using learnIT.ChatForms;
using learnIT.Class;
using learnIT.ClassForms;
using learnIT.Controller;
using learnIT.Data;
using learnIT.Forms;
using learnIT.TasksForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnIT.TasksForms
{
    public partial class TaskForm : Form
    {
        TaskDataAccess TaskAccess = new TaskDataAccess();
        List<StudentClass> ClassList = new List<StudentClass>();
        List<UserTask> TaskList = new List<UserTask>();
        GetClass getDbClass = new GetClass();
        GetTask GetDbTask = new GetTask();
        int Id;
        public TaskForm(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void buttonAssigned_Click(object sender, EventArgs e)
        {
            flowLayoutPanelNoDead.Visible = true;
            flowLayoutPanelLater.Controls.Clear();
            flowLayoutPanelNoDead.Controls.Clear();
            

            flowLayoutPanelNoDead.Controls.Add(panelNoDead);
            flowLayoutPanelLater.Controls.Add(panelLater);
            labelLater.Text = "Later";
            labelNoDeadline.Text = "No Deadline";

            ClassList = TaskAccess.GetStudentClasses(Id);
            if (ClassList == null)
            {
                Console.WriteLine("No Class");
            }
            else
            {
                foreach (StudentClass Class in ClassList)
                {
                    Console.WriteLine(Class.student_class_id);
                    List<StudentTask> AllStudentTaskPassed = new List<StudentTask>();
                    int classId = Class.class_id;
                    int studentClassId = Class.student_class_id;

                   
                    TaskList = TaskAccess.GetAllTask(classId);
                    foreach (UserTask Task in TaskList)
                    {
                        int taskId = Task.task_id;

                        bool taskPassed = GetDbTask.TaskPassed(taskId, studentClassId);
                        if(!taskPassed)
                        {
                            string TaskDate = Task.task_date;
                            string TaskTime = Task.task_time;

                            if (String.IsNullOrEmpty(TaskDate) && String.IsNullOrEmpty(TaskTime))
                            {
                                string taskTitle = Task.task_title;
                                var classInfo = getDbClass.GetClassData(classId);
                                string subjectName = classInfo.Item1;
                                string datePost = Task.cur_date;
                                CreateNoDeadTask(taskId, taskTitle, subjectName, datePost, classId);
                            }
                            else
                            {
                                string taskTitle = Task.task_title;
                                var classInfo = getDbClass.GetClassData(classId);
                                string subjectName = classInfo.Item1;
                                string deadline = TaskDate;
                                CreateLaterTask(taskId, taskTitle, subjectName, deadline, classId);
                            }
                        }
                    }
                }
            }
            
            buttonAssigned.Enabled = false;
            buttonDone.Enabled = true;
        }

        private void CreateLaterTask(int taskId, string taskTitle, string subject, string deadline, int classId)
        {
            //add panel
            Panel dynamicPanel = new Panel();
            dynamicPanel.Name = $"Task{taskId}";
            dynamicPanel.BorderStyle = BorderStyle.FixedSingle;
            dynamicPanel.Size = new System.Drawing.Size(870, 90);
            dynamicPanel.MinimumSize = new System.Drawing.Size(870, 90);
            dynamicPanel.BackColor = Color.White;


            Label Title = new Label();
            Title.Text = $"{taskTitle}";
            Title.Font = new Font("Raleway", 14, FontStyle.Bold);
            Title.ForeColor = Color.FromArgb(53, 80, 112);
            Title.AutoSize = true;
            Title.Size = new System.Drawing.Size(86, 22);
            Title.Location = new Point(3, 8);
            dynamicPanel.Controls.Add(Title);

            Label Subject = new Label();
            Subject.Text = $"{subject}";
            Subject.Font = new Font("Raleway SemiBold", 12, FontStyle.Bold);
            Subject.ForeColor = Color.FromArgb(53, 80, 112);
            Subject.AutoSize = true;
            Subject.Size = new System.Drawing.Size(86, 22);
            Subject.Location = new Point(3, 34);
            dynamicPanel.Controls.Add(Subject);

            Label Date = new Label();
            Date.Text = $"Deadline: {deadline}";
            Date.Font = new Font("Raleway Medium", 9, FontStyle.Italic);
            Date.ForeColor = Color.FromArgb(53, 80, 112);
            Date.AutoSize = true;
            Date.Size = new System.Drawing.Size(86, 22);
            Date.Location = new Point(3, 56);
            dynamicPanel.Controls.Add(Date);

            dynamicPanel.Click += (sender, e) => PanelOnClick(sender, e, classId, taskId);
            Title.Click += (sender, e) => PanelOnClick(sender, e, classId, taskId);
            Subject.Click += (sender, e) => PanelOnClick(sender, e, classId, taskId);
            Date.Click += (sender, e) => PanelOnClick(sender, e, classId, taskId);

            flowLayoutPanelLater.Controls.Add(dynamicPanel);
        }

        private void CreateNoDeadTask(int taskId, string taskTitle, string subject, string currDate, int classId)
        {
            //add panel
            Panel dynamicPanel = new Panel();
            dynamicPanel.Name = $"Task{taskId}";
            dynamicPanel.BorderStyle = BorderStyle.FixedSingle;
            dynamicPanel.Size = new System.Drawing.Size(870, 90);
            dynamicPanel.MinimumSize = new System.Drawing.Size(870, 90);
            dynamicPanel.BackColor = Color.White;


            Label Title = new Label();
            Title.Text = $"{taskTitle}";
            Title.Font = new Font("Raleway", 14, FontStyle.Bold);
            Title.ForeColor = Color.FromArgb(53, 80, 112);
            Title.AutoSize = true;
            Title.Size = new System.Drawing.Size(86, 22);
            Title.Location = new Point(3, 8);
            dynamicPanel.Controls.Add(Title);

            Label Subject = new Label();
            Subject.Text = $"{subject}";
            Subject.Font = new Font("Raleway SemiBold", 12, FontStyle.Bold);
            Subject.ForeColor = Color.FromArgb(53, 80, 112);
            Subject.AutoSize = true;
            Subject.Size = new System.Drawing.Size(86, 22);
            Subject.Location = new Point(3, 34);
            dynamicPanel.Controls.Add(Subject);

            Label Date = new Label();
            Date.Text = $"Date Posted: {currDate}";
            Date.Font = new Font("Raleway Medium", 9, FontStyle.Italic);
            Date.ForeColor = Color.FromArgb(53, 80, 112);
            Date.AutoSize = true;
            Date.Size = new System.Drawing.Size(86, 22);
            Date.Location = new Point(3, 56);
            dynamicPanel.Controls.Add(Date);

            dynamicPanel.Click += (sender, e) => PanelOnClick(sender, e, classId, taskId);
            Title.Click += (sender, e) => PanelOnClick(sender, e, classId, taskId);
            Subject.Click += (sender, e) => PanelOnClick(sender, e, classId, taskId);
            Date.Click += (sender, e) => PanelOnClick(sender, e, classId, taskId);

            flowLayoutPanelNoDead.Controls.Add(dynamicPanel);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            flowLayoutPanelLater.Controls.Clear();
            flowLayoutPanelNoDead.Controls.Clear();

            flowLayoutPanelLater.Controls.Add(panelLater);
            labelLater.Text = "Task Passed";

            ClassList = TaskAccess.GetStudentClasses(Id);
            if (ClassList == null)
            {
                Console.WriteLine("No Class");
            }
            else
            {
                foreach (StudentClass Class in ClassList)
                {
                    Console.WriteLine(Class.student_class_id);
                    List<StudentTask> AllStudentTaskPassed = new List<StudentTask>();
                    int classId = Class.class_id;
                    int studentClassId = Class.student_class_id;


                    TaskList = TaskAccess.GetAllTask(classId);
                    foreach (UserTask Task in TaskList)
                    {
                        int taskId = Task.task_id;

                        bool taskPassed = GetDbTask.TaskPassed(taskId, studentClassId);
                        if (taskPassed)
                        {
                            string TaskDate = Task.task_date;

                            string taskTitle = Task.task_title;
                            var classInfo = getDbClass.GetClassData(classId);
                            string subjectName = classInfo.Item1;
                            string deadline = TaskDate;
                            CreateLaterTask(taskId, taskTitle, subjectName, deadline, classId);
                        }
                    }
                }
            }

            buttonDone.Enabled = false;
            buttonAssigned.Enabled = true;
           
            flowLayoutPanelNoDead.Visible = false;
        }

        private void PanelOnClick(object sender, EventArgs e, int classId, int taskId)
        {
            StudentTaskOverview form = new StudentTaskOverview(taskId, classId, Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            GetData GetRole = new GetData();

            var User = GetRole.DashboardLogin(Id);
            string role = User.Item4;
            if (role == "Admin")
            {
                AdminClasses form = new AdminClasses(Id);
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                StudentClasses form = new StudentClasses(Id);
                this.Hide();
                form.ShowDialog();
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile form = new Profile(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            Chatbox form = new Chatbox(Id);
            this.Hide();
            form.ShowDialog();
        }
    }
}

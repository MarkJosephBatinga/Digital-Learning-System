using learnIT.ChatForms;
using learnIT.Class;
using learnIT.ClassForms;
using learnIT.Controller;
using learnIT.Data;
using learnIT.TasksForm;
using learnIT.TasksForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnIT.Forms
{
    public partial class Dashboard : Form
    {
        GetData GetUserProfile = new GetData();
        int Id;
        ClassDataAccess ClassAccess = new ClassDataAccess();
        GetTask GetAllTask = new GetTask();
        List<UserTask> TasksInfo = new List<UserTask>();

        public Dashboard(int id)
        {
            InitializeComponent();
            Id = id;

            var User = GetUserProfile.DashboardLogin(id);
            labelDashbordName.Text = $"Welcome Back, {User.Item1}!!";


            if (User.Item4 == "Student")
            {
                //Add Student Clasess in flowLayoutClasses
                List<StudentClass> AllStudentClass = ClassAccess.SelectAllStudentClass(Id);
                foreach (var indStudentClass in AllStudentClass)
                {
                    List<UserClass> AllClass = ClassAccess.GetClassInfo(indStudentClass.class_id);
                    foreach (var indClass in AllClass)
                    {
                        CreateClass(indClass.class_code);
                        TasksInfo = GetAllTask.GetTaskUsingClassId(indClass.class_id);
                        if (TasksInfo != null)
                        {
                            foreach (var TaskInfo in TasksInfo)
                            {
                                CreateTask(TaskInfo, indClass.class_title);
                            }
                        }
                        else
                        {
                            Console.WriteLine("NoTask");
                        }
                    }
                }
            }
            else if (User.Item4 == "Admin")
            {
                //Add Clasess in flowLayoutClasses
                List<UserClass> AllClass = ClassAccess.SelectAllClass(Id);
                foreach (var indClass in AllClass)
                {
                    CreateClass(indClass.class_code);
                    TasksInfo = GetAllTask.GetTaskUsingClassId(indClass.class_id);
                    if(TasksInfo != null)
                    {
                        foreach(var TaskInfo in TasksInfo)
                        {
                            CreateTask(TaskInfo, indClass.class_title);
                        }
                    }
                   else
                    {
                        Console.WriteLine("NoTask");
                    }
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile form = new Profile(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonClass_Click(object sender, EventArgs e)
        {
            GetData GetRole = new GetData();

            var User = GetRole.DashboardLogin(Id);
            string role = User.Item4;
            if(role=="Admin")
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

        private void CreateClass(string classCode)
        {
            //add panel
            Panel dynamicPanel = new Panel();
            dynamicPanel.Name = $"Class1";
            dynamicPanel.Size = new System.Drawing.Size(190, 257);
            dynamicPanel.BackColor = Color.FromArgb(194, 209, 226);
            dynamicPanel.Margin = new Padding(10, 10, 10, 10);
            dynamicPanel.BorderStyle = BorderStyle.FixedSingle;

            //add picture box
            PictureBox pic = new PictureBox();
            pic.Image = Properties.Resources.ClassCovers;
            pic.Size = new System.Drawing.Size(183, 184);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Location = new Point(4, 3);
            dynamicPanel.Controls.Add(pic);

            //Add Class Code
            Label title = new Label();
            title.Text = $"{classCode}";
            title.Font = new Font("Raleway ExtraBold", 18.75f, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(53, 80, 112);
            title.Size = new Size(title.PreferredWidth, title.PreferredHeight);
            title.Location = new Point(4, 209);
            dynamicPanel.Controls.Add(title);

            flowLayoutPanelClasses.Controls.Add(dynamicPanel);
        }

        private void CreateTask(UserTask TaskInfo, string ClassTitle)
        {
            //add panel
            Panel dynamicPanel = new Panel();
            dynamicPanel.Name = $"{TaskInfo.task_id}";
            dynamicPanel.Size = new System.Drawing.Size(461, 94);
            dynamicPanel.BorderStyle = BorderStyle.FixedSingle;

            //Add Activity Number
            Label ActNo = new Label();
            ActNo.Text = $"{TaskInfo.task_title}";
            ActNo.Font = new Font("Raleway", 14, FontStyle.Bold);
            ActNo.ForeColor = Color.FromArgb(53, 80, 112);
            ActNo.Size = new Size(ActNo.PreferredWidth, ActNo.PreferredHeight);
            ActNo.Location = new Point(28, 13);
            dynamicPanel.Controls.Add(ActNo);

            //Add Class Title
            Label title = new Label();
            title.Text = $"{ClassTitle}";
            title.Font = new Font("Raleway SemiBold", 12f);
            title.ForeColor = Color.FromArgb(53, 80, 112);
            title.Size = new Size(title.PreferredWidth, title.PreferredHeight);
            title.Location = new Point(29, 45);
            dynamicPanel.Controls.Add(title);
            
            if(!String.IsNullOrEmpty(TaskInfo.task_date))
            {
                //Add task duedate
                Label date = new Label();
                date.Text = $"{TaskInfo.task_date}";
                date.Font = new Font("Raleway SemiBold", 14f);
                date.ForeColor = Color.FromArgb(53, 80, 112);
                date.Size = new Size(date.PreferredWidth, date.PreferredHeight);
                date.Location = new Point(332, 13);
                dynamicPanel.Controls.Add(date);

                //Add task duetime
                Label dueTime = new Label();
                dueTime.Text = $"{TaskInfo.task_time}";
                dueTime.Font = new Font("Raleway SemiBold", 12f);
                dueTime.ForeColor = Color.FromArgb(53, 80, 112);
                dueTime.Size = new Size(dueTime.PreferredWidth, dueTime.PreferredHeight);
                dueTime.Location = new Point(333, 45);
                dynamicPanel.Controls.Add(dueTime);
            }
            else 
            {
                //Add task duedate
                Label date = new Label();
                date.Text = $"No Deadline";
                date.Font = new Font("Raleway SemiBold", 14f);
                date.ForeColor = Color.FromArgb(53, 80, 112);
                date.Size = new Size(date.PreferredWidth, date.PreferredHeight);
                date.Location = new Point(332, 13);
                dynamicPanel.Controls.Add(date);
            }

            flowLayoutPanelTasks.Controls.Add(dynamicPanel);
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            TaskForm form = new TaskForm(Id);
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

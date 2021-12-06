using learnIT.Class;
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

namespace learnIT.ClassForms
{
    public partial class StudentEnrolledClass : Form
    {
        int Id;
        int ClassId;
        GetClass GetClassInfo = new GetClass();
        GetData GetUser = new GetData();
        GetTask GetTaskInfo = new GetTask();
        List<UserTask> TaskInfos = new List<UserTask>();

        public StudentEnrolledClass(int classId, int id)
        {
            InitializeComponent();
            Id = id;
            ClassId = classId;

            var ClassInfo = GetClassInfo.GetClassData(classId);
            //class title
            var classTitle = ClassInfo.Item1;
            //class section
            var classSection = ClassInfo.Item2;
            //class code
            var classCode = ClassInfo.Item3;
            //clas description
            var classDescription = ClassInfo.Item4;
            //class creators
            var classInstructor = ClassInfo.Item5;

            //set Label Names
            labelClassName.Text = $"{classCode} - {classTitle}";
            labelClassSection.Text = $"{classSection} - ";
            var userProfile = GetUser.DashboardLogin(classInstructor);
            var insFirstName = userProfile.Item1;
            var insLastName = userProfile.Item2;
            labelInstructor.Text = $"{insFirstName} {insLastName}";


            //PanelDescription
            labelInstruction.Text = $"{classDescription}";
            labelInstruct.Text = $"{insFirstName} {insLastName}";
            labelDate.Text = "Class Description";

            TaskInfos = GetTaskInfo.GetTasks(ClassId);
            foreach (UserTask taskInfo in TaskInfos)
            {
                Console.WriteLine($"Task No: {taskInfo.task_id}");
                CreateTask(taskInfo, $"{insFirstName} {insLastName}");
            }
        }

        private void CreateTask(UserTask TaskInfo, string instructor)
        {
            //add panel
            Panel dynamicPanel = new Panel();
            dynamicPanel.Name = $"Task{TaskInfo.task_id}";
            dynamicPanel.BorderStyle = BorderStyle.Fixed3D;
            dynamicPanel.AutoSize = true;
            dynamicPanel.Size = new System.Drawing.Size(950, 139);
            dynamicPanel.MinimumSize = new System.Drawing.Size(950, 139);
            dynamicPanel.BackColor = Color.FromArgb(194, 209, 226);
            dynamicPanel.Margin = new Padding(420, 5, 3, 3);
            dynamicPanel.Padding = new Padding(5, 5, 5, 10);


            //add profile picture
            PictureBox pic = new PictureBox();
            pic.Image = Properties.Resources.ProfileAvatar;
            pic.Size = new System.Drawing.Size(62, 49);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Location = new Point(18, 10);
            dynamicPanel.Controls.Add(pic);

            //add instructor
            Label Instructor = new Label();
            Instructor.Text = $"{instructor}";
            Instructor.Font = new Font("Raleway ExtraBold", 12, FontStyle.Bold);
            Instructor.ForeColor = Color.FromArgb(53, 80, 112);
            Instructor.AutoSize = true;
            Instructor.Size = new System.Drawing.Size(86, 22);
            Instructor.MinimumSize = new System.Drawing.Size(86, 22);
            Instructor.Location = new Point(86, 10);
            dynamicPanel.Controls.Add(Instructor);

            //add Deadline
            Label Deadline = new Label();
            if (String.IsNullOrEmpty(TaskInfo.task_date))
            {
                Deadline.Text = $"DeadLine: No Deadline";
            }
            else
            {
                Deadline.Text = $"DeadLine: {TaskInfo.task_date}";
            }
            Deadline.Font = new Font("Raleway ExtraBold", 11, FontStyle.Bold);
            Deadline.ForeColor = Color.FromArgb(53, 80, 112);
            Deadline.AutoSize = true;
            Deadline.Size = new System.Drawing.Size(171, 22);
            Deadline.Location = new Point(749, 10);
            dynamicPanel.Controls.Add(Deadline);

            //add date
            Label Date = new Label();
            Date.Text = $"{TaskInfo.cur_date}";
            Date.Font = new Font("Raleway Medium", 10, FontStyle.Italic);
            Date.ForeColor = Color.FromArgb(53, 80, 112);
            Date.AutoSize = true;
            Date.Size = new System.Drawing.Size(36, 18);
            Date.MinimumSize = new System.Drawing.Size(36, 18);
            Date.Location = new Point(87, 32);
            dynamicPanel.Controls.Add(Date);

            //add Instruction
            Label Instruction = new Label();
            Instruction.Text = $"{TaskInfo.task_description}";
            Instruction.Font = new Font("Raleway Medium", 11, FontStyle.Bold);
            Instruction.ForeColor = Color.FromArgb(53, 80, 112);
            Instruction.AutoSize = true;
            Instruction.MaximumSize = new System.Drawing.Size(600, 600);
            Instruction.Size = new System.Drawing.Size(86, 83);
            Instruction.Location = new Point(86, 83);
            dynamicPanel.Controls.Add(Instruction);

            //add pdf
            Panel pdfPanel = new Panel();
            pdfPanel.Name = $"pdf1";
            pdfPanel.Location = new Point(794, 50);
            pdfPanel.AutoSize = true;
            pdfPanel.Size = new System.Drawing.Size(147, 48);
            pdfPanel.MinimumSize = new System.Drawing.Size(147, 48);
            pdfPanel.BackColor = Color.White;

            //add pdfPic
            PictureBox pdfPic = new PictureBox();
            pdfPic.Image = Properties.Resources.pdf;
            pdfPic.Size = new System.Drawing.Size(35, 43);
            pdfPic.SizeMode = PictureBoxSizeMode.Zoom;
            pdfPic.Location = new Point(9, 0);
            pdfPanel.Controls.Add(pdfPic);

            Label pdfTitle = new Label();
            pdfTitle.Text = $"PDFInside";
            pdfTitle.Font = new Font("Raleway Medium", 11, FontStyle.Bold);
            pdfTitle.ForeColor = Color.FromArgb(53, 80, 112);
            pdfTitle.AutoSize = true;
            pdfTitle.Size = new System.Drawing.Size(86, 83);
            pdfTitle.Location = new Point(50, 13);
            pdfPanel.Controls.Add(pdfTitle);

            if (String.IsNullOrEmpty(TaskInfo.task_filename) || String.IsNullOrEmpty(TaskInfo.task_filepath))
            {
                Console.WriteLine("No pdf File");
            }
            else
            {
                dynamicPanel.Controls.Add(pdfPanel);
            }

            //add panel to flowlayout
            flowLayoutPanelTasks.Controls.Add(dynamicPanel);

            //add click event handler
            dynamicPanel.Click += (sender, e) => PanelOnClick(sender, e, TaskInfo.task_id);
            Deadline.Click += (sender, e) => PanelOnClick(sender, e, TaskInfo.task_id);
            Instruction.Click += (sender, e) => PanelOnClick(sender, e, TaskInfo.task_id);
        }

        public void PanelOnClick(object sender, EventArgs e, int taskId)
        {
            StudentTaskOverview form = new StudentTaskOverview(taskId, ClassId, Id);
            this.Hide();
            form.ShowDialog();
        }
        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            StudentClasses form = new StudentClasses(Id);
            this.Hide();
            form.ShowDialog();
        }
    }
}

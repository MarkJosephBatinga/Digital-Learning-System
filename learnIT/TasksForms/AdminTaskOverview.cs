using learnIT.ClassForms;
using learnIT.Controller;
using learnIT.Data;
using learnIT.TasksForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnIT.TasksForms
{
    public partial class AdminTaskOverview : Form
    {
        GetTask GetDbTask = new GetTask();
        GetData GetName = new GetData();
        int ClassId;
        int Id;
        int TaskId;
        UserTask TaskInfo = new UserTask();
        TaskDataAccess TaskAccess = new TaskDataAccess();
        List<StudentClass> ListAllStudents = new List<StudentClass>();
        StudentTask StudentTaskInfo = new StudentTask();


        public AdminTaskOverview(int taskId, int classId, int id)
        {
            InitializeComponent();
            ClassId = classId;
            Id = id;
            TaskId = taskId;


            TaskInfo = GetDbTask.GetSingleTask(taskId);

            //Overview
            labelTitle.Text = $"{TaskInfo.task_title}";
            labelDate.Text = $"{TaskInfo.cur_date}";

            //deadline
            if(String.IsNullOrEmpty(TaskInfo.task_date))
            {
                labelDeadline.Text = "Deadline: No Deadline";
                labeldeadlineTime.ResetText();
            }
            else
            {
                labelDeadline.Text = $"Deadline: {TaskInfo.task_date}";
                labeldeadlineTime.Text = $"Time: {TaskInfo.task_time}";
            }

            //Instruction
            labelInstruction.Text = $"{TaskInfo.task_description}";

            if (String.IsNullOrEmpty(TaskInfo.task_filename))
            {
                panelOverviewPdf.Visible = false;
            }
            else
            {
                labelOverviewPdfTitle.Text = $"{TaskInfo.task_filename}";
                //add click event handler
                panelOverviewPdf.Click += (sender, e) => PanelOnClick(sender, e, TaskInfo.task_filepath);
                labelOverviewPdfTitle.Click += (sender, e) => PanelOnClick(sender, e, TaskInfo.task_filepath);
            }

            //Add all students
            ListAllStudents = GetDbTask.GetAllStudents(TaskInfo.class_id);
            foreach(var Student in ListAllStudents)
            {
                var studentName = GetName.DashboardLogin(Student.student_id);
                ListStudent(studentName.Item1, studentName.Item2, Student.student_id);
            }
        }



        private void ListStudent(string firstName, string lastName, int studentId)
        {
            //add panel
            Panel dynamicPanel = new Panel();
            dynamicPanel.Name = $"student{studentId}";
            dynamicPanel.BorderStyle = BorderStyle.None;
            dynamicPanel.Size = new System.Drawing.Size(630, 47);
            dynamicPanel.MinimumSize = new System.Drawing.Size(630, 47);
            dynamicPanel.BackColor = Color.White;


            Label StudentName = new Label();
            StudentName.Text = $"{lastName}, {firstName}";
            StudentName.Font = new Font("Raleway Medium", 11, FontStyle.Bold);
            StudentName.ForeColor = Color.FromArgb(53, 80, 112);
            StudentName.AutoSize = true;
            StudentName.Size = new System.Drawing.Size(86, 83);
            StudentName.Location = new Point(38, 10);
            dynamicPanel.Controls.Add(StudentName);

            CheckBox checkBoxPassed = new CheckBox();
            checkBoxPassed.Location = new Point(520, 9);
            checkBoxPassed.Font = new Font("Raleway Medium", 11, FontStyle.Bold);
            checkBoxPassed.ForeColor = Color.FromArgb(53, 80, 112);
            checkBoxPassed.Text = "Passed";
            checkBoxPassed.Enabled = false;
            dynamicPanel.Controls.Add(checkBoxPassed);

            var studentClassIdInfo = GetDbTask.GetStudentClassId(ClassId, studentId);
            int studentClassId = studentClassIdInfo.student_class_id;
            StudentTaskInfo = GetDbTask.GetStudentTaskId(TaskId, studentClassId);

            if (StudentTaskInfo != null)
            {
                Button Grade = new Button();
                Grade.Text = $"Grade";
                Grade.Font = new Font("Raleway Medium", 9, FontStyle.Bold);
                Grade.BackColor = Color.FromArgb(53, 80, 112);
                Grade.ForeColor = Color.White;
                Grade.FlatStyle = FlatStyle.Flat;
                Grade.AutoSize = true;
                Grade.Size = new System.Drawing.Size(57, 22);
                Grade.Location = new Point(370, 10);
                dynamicPanel.Controls.Add(Grade);

                TextBox textGrade = new TextBox();
                textGrade.Font = new Font("Raleway Medium", 9, FontStyle.Bold);
                textGrade.Size = new System.Drawing.Size(38, 20);
                textGrade.Location = new Point(443, 15);
                dynamicPanel.Controls.Add(textGrade);

                var stClassId = StudentTaskInfo.student_class_id;

                if (StudentTaskInfo.student_grade == 0)
                {
                    Grade.Enabled = true;
                    textGrade.Enabled = true;

                    Grade.Click += (sender, e) => GradeOnClick(sender, e, textGrade.Text, stClassId, textGrade, Grade);
                }
                else
                {
                    Grade.Enabled = false;
                    Grade.BackColor = Color.White;
                    textGrade.Enabled = false;
                    textGrade.Text = $"{StudentTaskInfo.student_grade}";
                }
                

                if (!String.IsNullOrEmpty(StudentTaskInfo.pdf_name))
                {
                    // add pdfPic
                    PictureBox pdfPic = new PictureBox();
                    pdfPic.Image = Properties.Resources.pdf;
                    pdfPic.Size = new System.Drawing.Size(31, 28);
                    pdfPic.SizeMode = PictureBoxSizeMode.Zoom;
                    pdfPic.Location = new Point(298, 10);
                    dynamicPanel.Controls.Add(pdfPic);

                    string pdfPath = StudentTaskInfo.pdf_path;
                    pdfPic.Click += (sender, e) => PanelOnClick(sender, e, pdfPath);
                }
                checkBoxPassed.Checked = true;
            }
            
            //add panel to flowlayout
            flowLayoutPanelStudents.Controls.Add(dynamicPanel);
        }

        private void GradeOnClick(object sender, EventArgs e, string gradeText, int studentClassId, TextBox textGrade, Button grade)
        {
            if(!String.IsNullOrEmpty(gradeText))
            {
                Console.WriteLine(textGrade);
                try
                {
                    Console.WriteLine(gradeText);
                    int GradeInt = int.Parse(gradeText);

                    TaskAccess.SetStudentGrade(TaskId, GradeInt, studentClassId);

                    grade.Enabled = false;
                    grade.BackColor = Color.White;
                    textGrade.Enabled = false;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Grade needs to be a number");
                }
            }
            else
            {
                MessageBox.Show("Please Input a Grade");
            }
           
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CreatedClass form = new CreatedClass(ClassId, Id);
            this.Hide();
            form.ShowDialog();
        }

        private void PanelOnClick(object sender, EventArgs e, string filePath)
        {
            Process.Start(filePath);
        }
    }
}

using learnIT.ClassForms;
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
    public partial class StudentTaskOverview : Form
    {
        GetTask GetDbTask = new GetTask();
        StudentClass StudentClassInfo = new StudentClass();
        TaskDataAccess TaskAccess = new TaskDataAccess();
        StudentTask StudentTaskInfo = new StudentTask();
        int ClassId;
        int Id;
        int TaskId;
        string FilePath;
        UserTask TaskInfo = new UserTask();

        public StudentTaskOverview(int taskId, int classId, int id)
        {
            InitializeComponent();
            ClassId = classId;
            Id = id;
            TaskId = taskId;
            errorMessageAdd.ResetText();

            TaskInfo = GetDbTask.GetSingleTask(taskId);

            //Overview
            labelTitle.Text = $"{TaskInfo.task_title}";
            labelDate.Text = $"{TaskInfo.cur_date}";

            //deadline
            if (String.IsNullOrEmpty(TaskInfo.task_date))
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

            //check if student pass the task
            var studentClassIdInfo = GetDbTask.GetStudentClassId(ClassId, Id);
            int studentClassId = studentClassIdInfo.student_class_id;
            StudentTaskInfo = GetDbTask.GetStudentTaskId(taskId, studentClassId);
            if(StudentTaskInfo != null)
            {
                if(StudentTaskInfo.student_grade == 0)
                {
                    labelAssigned.Text = "Submitted";
                }
                else
                {
                    labelAssigned.Text = $"Graded: {StudentTaskInfo.student_grade}";
                    buttonAdd.Enabled = false;
                    buttonSubmit.Enabled = false;
                    buttonAdd.Text = $"{StudentTaskInfo.pdf_name}";
                }
            }
            else
            {
                labelAssigned.Text = "Assigned";
            }
        }

        private void PanelOnClick(object sender, EventArgs e, string filePath)
        {
            Process.Start(filePath);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.InitialDirectory = @"C:\";
            openFile.Title = "Select File";
            openFile.FilterIndex = 2;
            openFile.Filter = "PDF (*.pdf)|*.pdf";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FilePath = $@"file:\\\{openFile.FileName}".Replace(" ", "%20");
                buttonAdd.Text = Path.GetFileName(openFile.FileName);
                buttonAdd.Enabled = false;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            errorMessageAdd.ResetText();
            List<string> StudentTaskInfo = new List<string>();
            if(buttonAdd.Text != "Add File")
            {
                //student_class_id
                StudentClassInfo = GetDbTask.GetStudentClassId(ClassId, Id);
                int studentClassId = StudentClassInfo.student_class_id;
                //student_pass
                string studentPass = "Pass";
                StudentTaskInfo.Add(studentPass);
                //date_passed
                string currDate = DateTime.Now.ToString("MM-dd-yyyy");
                StudentTaskInfo.Add(currDate);
                //student pdf name
                string pdfName = buttonAdd.Text;
                StudentTaskInfo.Add(pdfName);
                StudentTaskInfo.Add(FilePath);

                TaskAccess.CreateNewStudentTask(TaskId, studentClassId, StudentTaskInfo);
                labelAssigned.Text = "Submitted";
                buttonSubmit.Enabled = false;
            }
            else
            {
                errorMessageAdd.Text = "PDF File Required";
            }
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            StudentEnrolledClass form = new StudentEnrolledClass(ClassId, Id);
            this.Hide();
            form.ShowDialog();
        }
    }
}

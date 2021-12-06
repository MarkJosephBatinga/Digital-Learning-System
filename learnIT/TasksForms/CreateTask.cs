using learnIT.Class;
using learnIT.ClassForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnIT.TasksForm
{
    public partial class CreateTask : Form
    {
        string FilePath;
        int Id;
        int ClassId;
        GetClass GetClassInfo = new GetClass();

        public CreateTask(int classId, int id)
        {
            InitializeComponent();
            Id = id;
            ClassId = classId;
            ErrorMessages();

            var ClassInfo = GetClassInfo.GetClassData(classId);
            //class title
            var classTitle = ClassInfo.Item1;
            //class section
            var classSection = ClassInfo.Item2;
            //class code
            var classCode = ClassInfo.Item3;

            //set Label Names
            labelClassName.Text = $"{classCode} - {classTitle}";
            labelClassSection.Text = $"{classSection}";
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            openFile.InitialDirectory = @"C:\";
            openFile.Title = "Select File";
            openFile.FilterIndex = 2;
            openFile.Filter = "PDF (*.pdf)|*.pdf";
            
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                FilePath = $@"file:\\\{openFile.FileName}".Replace(" ", "%20");
                labelChooseFile.Text = Path.GetFileName(openFile.FileName);
            }
        }

        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            ErrorMessages();
            ValidateTask isDataValid = new ValidateTask();

            var title = isDataValid.IsTaskNull(textTitle.Text);
            var type = isDataValid.IsTaskNull(comboBoxTaskType.Text);
            var descript = isDataValid.IsTaskNull(textDescription.Text);
            var deadlineDate = dateDeadline.Value.ToString("MM-dd-yyyy");
            var deadlineTime = timeDeadline.Value.ToString("h:mm tt");

            if (title)
            {
                errorMessageTitle.Text = "Title is Required";
            }
            else if(type)
            {
                errorMessageType.Text = "Task type is Required";
            }
            else if(descript)
            {
                errorMessageDes.Text = "Task Description is Required";
            }
            else
            {
                if (checkBoxNone.Checked)
                {
                    Console.WriteLine("No Deadline");
                    if (labelChooseFile.Text == "Choose File")
                    {
                        Console.WriteLine("No file");
                        AddTaskToDatabase(null, null, null, null);
                    }
                    else
                    {
                        Console.WriteLine(FilePath);
                        AddTaskToDatabase(null, null, labelChooseFile.Text, FilePath);
                    }
                }
                else
                {
                    Console.WriteLine($"{deadlineDate}, {deadlineTime}");
                    if (labelChooseFile.Text == "Choose File")
                    {
                        Console.WriteLine("No file");
                        AddTaskToDatabase(deadlineDate, deadlineTime, null, null);
                    }
                    else
                    {
                        Console.WriteLine(FilePath);
                        AddTaskToDatabase(deadlineDate, deadlineTime, labelChooseFile.Text, FilePath);
                    }
                }
            }
        }

        private void AddTaskToDatabase(string deadlineDate, string deadlineTime, string fileName, string filePath)
        {
            List<string> TaskInfo = new List<string>();
            TaskDataAccess TaskAccess = new TaskDataAccess();
            //class_id

            //cur_date
            TaskInfo.Add(DateTime.Now.ToString("MM-dd-yyyy"));
            //task_title
            TaskInfo.Add(textTitle.Text);
            //task_type
            TaskInfo.Add(comboBoxTaskType.Text);
            //task_date
            TaskInfo.Add(deadlineDate);
            //task_time
            TaskInfo.Add(deadlineTime);
            //task_filename
            TaskInfo.Add(fileName);
            //task_filepath
            TaskInfo.Add(filePath);
            //task_description
            TaskInfo.Add(textDescription.Text);

            TaskAccess.CreateNewTask(ClassId, TaskInfo);
            CreatedClass form = new CreatedClass(ClassId, Id);
            this.Hide();
            form.ShowDialog();
        }
        public void ErrorMessages()
        {
            errorMessageTitle.ResetText();
            errorMessageType.ResetText();
            errorMessageDes.ResetText();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            CreatedClass form = new CreatedClass(ClassId, Id);
            this.Hide();
            form.ShowDialog();
        }
    }
}

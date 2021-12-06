using learnIT.ChatForms;
using learnIT.Class;
using learnIT.Controller;
using learnIT.Data;
using learnIT.DialogForms;
using learnIT.Forms;
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
    public partial class StudentClasses : Form
    {
        int Id;
        Form f;
        ClassDataAccess ClassAccess = new ClassDataAccess();
        GetData GetInstructor = new GetData();

        public StudentClasses(int id)
        {
            InitializeComponent();
            Id = id;
            f = this;

            List<StudentClass> Classes = new List<StudentClass>();
            Classes = ClassAccess.GetStudentClass(Id);
            foreach(var Class in Classes)
            {
                int classId = Class.class_id;
                List<UserClass> AllClass = ClassAccess.GetClassInfo(classId);
                foreach (var ClassInfos in AllClass)
                {
                    int instructId = ClassInfos.class_creator;
                    var Instructor = GetInstructor.DashboardLogin(instructId);
                    CreateClass(ClassInfos.class_code, Instructor.Item1, Instructor.Item2, ClassInfos.class_section, ClassInfos.class_id); ;
                }
            }

        }


        private void CreateClass(string code, string firstName, string lastName, string section, int classId)
        {
            //add panel
            Panel dynamicPanel = new Panel();
            dynamicPanel.Name = $"Class1{classId}";
            dynamicPanel.Size = new System.Drawing.Size(400, 400);
            dynamicPanel.BackColor = Color.FromArgb(194, 209, 226);
            dynamicPanel.Margin = new Padding(10, 10, 10, 10);

            //add picture box
            PictureBox pic = new PictureBox();
            pic.Image = Properties.Resources.ClassCovers;
            pic.Size = new System.Drawing.Size(400, 170);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Location = new Point(0, 10);
            dynamicPanel.Controls.Add(pic);

            //Add Class Code
            Label title = new Label();
            title.Text = $"{code}";
            title.Font = new Font("Raleway ExtraBold", 18.75f, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(53, 80, 112);
            title.Size = new Size(title.PreferredWidth, title.PreferredHeight);
            title.Location = new Point(5, 180);
            dynamicPanel.Controls.Add(title);

            //Add Instructor
            Label Admin = new Label();
            Admin.Text = $"Instructor: {firstName} {lastName}";
            Admin.Font = new Font("Raleway SemiBold", 14, FontStyle.Italic);
            Admin.ForeColor = Color.FromArgb(53, 80, 112);
            Admin.Size = new Size(Admin.PreferredWidth, Admin.PreferredHeight);
            Admin.Location = new Point(5, 230);
            dynamicPanel.Controls.Add(Admin);

            //Add Section
            Label Section = new Label();
            Section.Text = $"Class Section : {section}";
            Section.Font = new Font("Raleway SemiBold", 12, FontStyle.Italic);
            Section.ForeColor = Color.FromArgb(53, 80, 112);
            Section.Size = new Size(Section.PreferredWidth, Section.PreferredHeight);
            Section.Location = new Point(5, 270);
            dynamicPanel.Controls.Add(Section);

            //add Delete Button
            Button deleteButton = new Button();
            deleteButton.ResetText();
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.Image = Properties.Resources.DeleteButtonPic;
            deleteButton.Location = new Point(357, 357);
            deleteButton.Size = new System.Drawing.Size(40, 40);
            dynamicPanel.Controls.Add(deleteButton);

            //add click event handler
            dynamicPanel.Click += (sender, e) => PanelOnClick(sender, e, classId);
            title.Click += (sender, e) => PanelOnClick(sender, e, classId);
            Admin.Click += (sender, e) => PanelOnClick(sender, e, classId);
            Section.Click += (sender, e) => PanelOnClick(sender, e, classId);
            pic.Click += (sender, e) => PanelOnClick(sender, e, classId);

            //add click event listener to delete button
            deleteButton.Click += (sender, e) => DeleteOnClick(sender, e, classId);


            flowLayoutClasses.Controls.Add(dynamicPanel);
        }

        public void PanelOnClick(object sender, EventArgs e, int classId)
        {
            StudentEnrolledClass form = new StudentEnrolledClass(classId, Id);
            this.Hide();
            form.ShowDialog();
        }

        public void DeleteOnClick(object sender, EventArgs e, int classId)
        {
            string message = "Unenroll to this Class";
            string title = "Unenroll";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                ClassAccess.UnenrollStudentClass(classId);
                StudentClasses form = new StudentClasses(Id);
                this.Hide();
                form.ShowDialog();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonProfile_Click_1(object sender, EventArgs e)
        {
            Profile form = new Profile(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonJoinClass_Click_1(object sender, EventArgs e)
        {
            JoinClassDialog form = new JoinClassDialog(Id, f);
            form.ShowDialog();
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

using learnIT.ChatForms;
using learnIT.Class;
using learnIT.Controller;
using learnIT.Data;
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
    public partial class AdminClasses : Form
    {
        int Id;
        GetData GetUser = new GetData();
        ClassDataAccess ClassAccess = new ClassDataAccess();

        public AdminClasses(int id)
        {
            InitializeComponent();
            Id = id;

            var User = GetUser.DashboardLogin(Id);
            List<UserClass> AllClass = ClassAccess.SelectAllClass(Id);
            foreach(var indClass in AllClass)
            {
                CreateClass(indClass.class_code, User.Item1, User.Item2, indClass.class_section, indClass.class_id);
            }

            
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
        }

        private void buttonCreateClass_Click(object sender, EventArgs e)
        {
            CreateClass form = new CreateClass(Id);
            this.Hide();
            form.ShowDialog();
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

            //add Edit Button
            Button editButton = new Button();
            editButton.ResetText();
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.Image = Properties.Resources.EditButtonPic;
            editButton.Location = new Point(311, 357);
            editButton.Size = new System.Drawing.Size(40, 40);
            dynamicPanel.Controls.Add(editButton);

            //add click event handler
            dynamicPanel.Click += (sender, e) => PanelOnClick(sender, e, classId);
            title.Click += (sender, e) => PanelOnClick(sender, e, classId);
            Admin.Click += (sender, e) => PanelOnClick(sender, e, classId);
            Section.Click += (sender, e) => PanelOnClick(sender, e, classId);
            pic.Click += (sender, e) => PanelOnClick(sender, e, classId);

            //add click event handler on edit class
            editButton.Click += (sender, e) => EditButtonOnClick(sender, e, classId);

            //add click event handler on delete class
            deleteButton.Click += (sender, e) => DeleteButtonOnClick(sender, e, classId);

            flowLayoutClasses.Controls.Add(dynamicPanel);
        }

        public void EditButtonOnClick(object sender, EventArgs e, int classId)
        {
            EditClass form = new EditClass(classId, Id);
            this.Hide();
            form.ShowDialog();
        }

        public void PanelOnClick(object sender, EventArgs e, int classId)
        {
            CreatedClass form = new CreatedClass(classId, Id);
            this.Hide();
            form.ShowDialog();
        }

        public void DeleteButtonOnClick(object sender, EventArgs e, int classId)
        {
            string message = "All Data about this class will be deleted";
            string title = "Delete Class";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                ClassAccess.DeleteUserClass(classId);
                AdminClasses form = new AdminClasses(Id);
                this.Hide();
                form.ShowDialog();
            }
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

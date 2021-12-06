using learnIT.Chat;
using learnIT.Class;
using learnIT.ClassForms;
using learnIT.Controller;
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

namespace learnIT.ChatForms
{
    public partial class Chatbox : Form
    {
        int Id;
        int ClassId;
        GetData GetUserInfo = new GetData();
        ClassDataAccess ClassAccess = new ClassDataAccess();
        ChatDataAccess ChatAccess = new ChatDataAccess();
        public Chatbox(int id)
        {
            InitializeComponent();
            Id = id;

            labelSubjectName.ResetText();
            pictureBoxAvatar.Visible = false;
            panelSend.Visible = false;
            var User = GetUserInfo.DashboardLogin(Id);
            string role = User.Item4;
            if (role == "Admin")
            {
                var ClassInfo = ClassAccess.SelectAllClass(Id);
                foreach(var Class in ClassInfo)
                {
                    CreateGroup(Class.class_id, Class.class_title, Class.class_code);
                }
            }
            else
            {
                var ClassInfo = ClassAccess.GetStudentClass(Id);
                foreach (var StudentClass in ClassInfo)
                {
                    int classId = StudentClass.class_id;
                    var AllClass = ClassAccess.GetClassInfo(classId);
                    foreach (var Class in AllClass)
                    {
                        CreateGroup(Class.class_id, Class.class_title, Class.class_code);
                    }
                   
                }
            }
            
        }

       
        public void PanelOnClick(object sender, EventArgs e, string title, int classId)
        {
            tableLayoutPanelMessage.Controls.Clear();
            pictureBoxAvatar.Visible = true;
            labelSubjectName.Text = title;
            panelSend.Visible = true;
            ClassId = classId;

            var ClassMessage = ChatAccess.GetAllMessage(classId);
            foreach(var Message in ClassMessage)
            {
                GetMessage(Message.users_id, Message.user_message, Message.curr_time, Message.curr_date);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            List<string> ChatInfo = new List<string>();

            tableLayoutPanelMessage.Controls.Clear();

            string message = textBoxMessage.Text;
            ChatInfo.Add(message);
            string currDate = DateTime.Now.ToString("MM-dd-yyyy");
            ChatInfo.Add(currDate);
            string currTime = DateTime.Now.ToString("h:mm tt");
            ChatInfo.Add(currTime);
            int classId = ClassId;

            if(classId != 0)
            {
                ChatAccess.AddNewMessage(Id, classId, ChatInfo);
                var ClassMessage = ChatAccess.GetAllMessage(classId);
                foreach (var Message in ClassMessage)
                {
                    GetMessage(Message.users_id, Message.user_message, Message.curr_time, Message.curr_date);
                }
            }
            else
            {
                Console.WriteLine("No Class");
            }
        }


        private void GetMessage(int id, string message, string currTime, string currDate)
        {

            //Add Last Message
            Label Message = new Label();
            Message.Text = $"{message}";
            Message.Font = new Font("Raleway", 10f, FontStyle.Italic);
            Message.ForeColor = Color.FromArgb(53, 80, 112);
            Message.BackColor = Color.FromArgb(194, 209, 226);
            Message.AutoSize = true;
            Message.Padding = new Padding(10, 10, 10, 10);
            


            var User = GetUserInfo.DashboardLogin(id);
            //Add Name
            Label Name = new Label();
            Name.Text = $"{User.Item1}";
            Name.Font = new Font("Raleway", 9f, FontStyle.Italic);
            Name.ForeColor = Color.FromArgb(53, 80, 112);
            Name.AutoSize = true;
            Name.Padding = new Padding(10, 10, 10, 10);
            

            tableLayoutPanelMessage.RowCount += 2;

            if(id == Id)
            {
                Name.Dock = DockStyle.Right;
                Message.Dock = DockStyle.Right;
                tableLayoutPanelMessage.Controls.Add(Name, 2, tableLayoutPanelMessage.RowCount);
                tableLayoutPanelMessage.Controls.Add(Message, 2, tableLayoutPanelMessage.RowCount + 1);
            }
           else
            {
                Name.Dock = DockStyle.Left;
                Message.Dock = DockStyle.Left;
                tableLayoutPanelMessage.Controls.Add(Name, 0, tableLayoutPanelMessage.RowCount);
                tableLayoutPanelMessage.Controls.Add(Message, 0, tableLayoutPanelMessage.RowCount + 1);
            }

            textBoxMessage.ResetText();
        }

        private void CreateGroup(int classId, string className, string classCode)
        {
           
            //add panel
            Panel dynamicPanel = new Panel();
            dynamicPanel.Name = $"Class{classId}";
            dynamicPanel.Size = new System.Drawing.Size(330, 60);
            dynamicPanel.BackColor = Color.FromArgb(194, 209, 226);
            dynamicPanel.BorderStyle = BorderStyle.FixedSingle;
            dynamicPanel.MaximumSize = new System.Drawing.Size(330, 60);
            dynamicPanel.MinimumSize = new System.Drawing.Size(330, 60);

            //add picture box
            PictureBox pic = new PictureBox();
            pic.Image = Properties.Resources.group;
            pic.Size = new System.Drawing.Size(56, 45);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Location = new Point(10, 10);
            dynamicPanel.Controls.Add(pic);

            //Add Class Name
            Label title = new Label();
            title.Text = $"{className}";
            title.Font = new Font("Raleway ExtraBold", 12f, FontStyle.Bold);
            title.ForeColor = Color.FromArgb(53, 80, 112);
            title.Size = new Size(title.PreferredWidth, title.PreferredHeight);
            title.Location = new Point(72, 10);
            dynamicPanel.Controls.Add(title);

            //Add Last Message
            Label lMessage = new Label();
            lMessage.Text = $"Class Code: {classCode}";
            lMessage.Font = new Font("Raleway", 10f, FontStyle.Italic);
            lMessage.ForeColor = Color.FromArgb(53, 80, 112);
            lMessage.Size = new Size(lMessage.PreferredWidth, lMessage.PreferredHeight);
            lMessage.Location = new Point(72, 32);
            dynamicPanel.Controls.Add(lMessage);


            flowLayoutGroups.Controls.Add(dynamicPanel);

            dynamicPanel.Click += (sender, e) => PanelOnClick(sender, e, className, classId);
            pic.Click += (sender, e) => PanelOnClick(sender, e, className, classId);
            title.Click += (sender, e) => PanelOnClick(sender, e, className, classId);
            lMessage.Click += (sender, e) => PanelOnClick(sender, e, className, classId);
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

        private void buttonTask_Click(object sender, EventArgs e)
        {
            TaskForm form = new TaskForm(Id);
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
    }
}

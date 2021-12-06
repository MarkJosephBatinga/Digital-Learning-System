using learnIT.ChatForms;
using learnIT.Class;
using learnIT.Controller;
using learnIT.Forms;
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
   
    public partial class CreateClass : Form
    {
        GetData GetUser = new GetData();
        ClassDataAccess ClassAccess = new ClassDataAccess();
        int Id;

        public CreateClass(int id)
        {
            InitializeComponent();
            Id = id;
            var User = GetUser.DashboardLogin(id);

            ErrorMessages();
            labelUserName.Text = $"{User.Item1} {User.Item2}";
        }

        private void buttonCreateClass_Click(object sender, EventArgs e)
        {
            ErrorMessages();
            List<string> ClassData = new List<string>();
            ValidateClass IsClassValid = new ValidateClass();
            //
            var title = IsClassValid.IsClassNull(textTitle.Text);
            var section = IsClassValid.IsClassNull(comboBoxSection.Text);
            var code = IsClassValid.IsClassNull(textSubjectCode.Text);

            if (title)
            {
                errorMessageTitle.Text = "Title is Required";
            }
            else if (section)
            {
                errorMessageSection.Text = "Section is Required";
            }
            else if (code)
            {
                errorMessageCode.Text = "Subject Code is Required";
            }
            else
            {
                //title 0
                ClassData.Add(textTitle.Text);
                //section 1
                ClassData.Add(comboBoxSection.Text);
                //code 2
                ClassData.Add(textSubjectCode.Text);
                //description 3
                ClassData.Add(textDescription.Text);

                ClassAccess.CreateNewClass(Id, ClassData);

                AdminClasses form = new AdminClasses(Id);
                this.Hide();
                form.ShowDialog();
            } 
        }

        private void ErrorMessages()
        {
            errorMessageTitle.ResetText();
            errorMessageSection.ResetText();
            errorMessageCode.ResetText();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AdminClasses form = new AdminClasses(Id);
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

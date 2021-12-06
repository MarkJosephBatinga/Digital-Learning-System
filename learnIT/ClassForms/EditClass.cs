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
    public partial class EditClass : Form
    {
        int Id;
        int ClassId;
        GetClass GetClassInfo = new GetClass();
        GetData GetUser = new GetData();
        ClassDataAccess ClassAccess = new ClassDataAccess();

        public EditClass(int classId, int id)
        {
            InitializeComponent();
            Id = id;
            ClassId = classId;
            ErrorMessages();

            
            var ClassInfo = GetClassInfo.GetClassData(classId);
            var User = GetUser.DashboardLogin(id);

            //Admin Name
            labelUserName.Text = $"{User.Item1}, {User.Item2}";

            //class title
            textTitle.Text = ClassInfo.Item1;
            //class section
            comboBoxSection.SelectedItem = ClassInfo.Item2;
            //class code
            textSubjectCode.Text = ClassInfo.Item3;
            //clas description
            textDescription.Text = ClassInfo.Item4;
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
            AdminClasses form = new AdminClasses(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile form = new Profile(Id);
            this.Hide();
            form.ShowDialog();
        }

        public void ErrorMessages()
        {
            errorMessageCode.ResetText();
            errorMessageSection.ResetText();
            errorMessageTitle.ResetText();
        }

        private void buttonEditClass_Click(object sender, EventArgs e)
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

                ClassAccess.EditClassData(ClassId, ClassData);
                AdminClasses form = new AdminClasses(Id);
                this.Hide();
                form.ShowDialog();
            }   
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            Chatbox form = new Chatbox(Id);
            this.Hide();
            form.ShowDialog();
        }
    }
}

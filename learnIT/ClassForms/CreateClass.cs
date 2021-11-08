using learnIT.Class;
using learnIT.Controller;
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

                foreach(var data in ClassData)
                {
                    Console.WriteLine(data);
                }

                ClassAccess.CreateNewClass(Id, ClassData);
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
            AdminClass form = new AdminClass(Id);
            this.Hide();
            form.ShowDialog();
        }
    }
}

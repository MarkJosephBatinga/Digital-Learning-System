using learnIT.Class;
using learnIT.ClassForms;
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

namespace learnIT.DialogForms
{
    public partial class JoinClassDialog : Form
    {
        int Id;
        Form lastForm;
        ValidateNewData ValidateData = new ValidateNewData();
        ClassDataAccess ClassAccess = new ClassDataAccess();
        GetClass GetClassId = new GetClass();

        public JoinClassDialog(int id, Form f)
        {
            Id = id;
            InitializeComponent();
            ErrorMessages();
            lastForm = f;
        }

        private void buttonJoin_Click(object sender, EventArgs e)
        {
            var classCode = ValidateData.isNull(textClassCode.Text);
            var classId = ValidateData.isNull(textClassId.Text);
            var intClassId = ValidateData.isDataNotInt(textClassId.Text);

            if (classCode)
            {
                errorMessageClassCode.Text = "Class Code is Required";
                textClassCode.ResetText();
            }
            else if (classId || intClassId)
            {
                errorMessageClassId.Text = "Invalid Class Id";
                textClassId.ResetText();
            }
            else
            {
                var SearchClass = GetClassId.GetClassId(textClassCode.Text, Int32.Parse(textClassId.Text));
                if (SearchClass == 0)
                {
                    ErrorMessages();
                    errorMessageClassCode.Text = "Class Doesn't Exists";
                    textClassCode.ResetText();
                    textClassId.ResetText();
                }
                else
                {
                    ClassAccess.CreateStudentClass(Id, SearchClass);
                    lastForm.Hide();
                    StudentClasses form = new StudentClasses(Id);
                    this.Hide();
                    form.ShowDialog();
                }
            }
        }

        public void ErrorMessages()
        {
            errorMessageClassCode.ResetText();
            errorMessageClassId.ResetText();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

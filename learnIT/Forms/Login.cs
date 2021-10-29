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

namespace learnIT.Forms
{
    public partial class Login : Form
    {
        List<string> loginValue = new List<string>();
        GetData searchData = new GetData();

        public Login()
        {
            InitializeComponent();
            errorMessages();
            comboBoxRole.SelectedIndex = 0;
            textBoxPassword.PasswordChar = '*';
 
        }

       

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            errorMessages();
            ValidateNewData validate = new ValidateNewData();

            var role = validate.isNull(comboBoxRole.Text);
            var email = validate.isNull(textBoxEmail.Text);
            var password = validate.isNull(textBoxPassword.Text);

            if (role || comboBoxRole.SelectedIndex == 0)
            {
                errorMessageRole.Text = "Please Select a Role";
            }
            else if (email)
            {
                errorMessageEmail.Text = "Invalid Email";
            }
            else if (password)
            {
                errorMessagePassword.Text = "Invalid Password";
            }
            else
            {
                loginValue.Clear();

                loginValue.Add(comboBoxRole.Text);
                loginValue.Add(textBoxEmail.Text);
                loginValue.Add(textBoxPassword.Text);

                int id = searchData.LoginData(loginValue);
                if(id!=0)
                {
                    Dashboard ds = new Dashboard(id);
                    this.Hide();
                    ds.ShowDialog();
                }
                else
                {
                    errorMessageInvalidUser.Text = "Invalid Credentials, Please try again";
                    textBoxPassword.ResetText();
                    comboBoxRole.SelectedIndex = 0;
                }
            }
        }

        private void errorMessages()
        {
            errorMessageRole.ResetText();
            errorMessageEmail.ResetText();
            errorMessagePassword.ResetText();
            errorMessageInvalidUser.ResetText();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register rs = new Register();
            this.Hide();
            rs.ShowDialog();
        }
    }
}

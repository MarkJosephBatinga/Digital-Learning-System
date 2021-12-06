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

namespace learnIT.DialogForms
{
    public partial class ValidateDeleteProfile : Form
    {
        int Id;

        public ValidateDeleteProfile(int id)
        {
            Id = id;
            InitializeComponent();
            errorMessagePassword.ResetText();

            textPassword.PasswordChar = '*';
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ValidateNewData isDataValid = new ValidateNewData();
            GetData getUser = new GetData();
            List<string> UserData = new List<string>();
            DeleteData deleteAllData = new DeleteData();

            var User = getUser.DashboardLogin(Id);
            

            var password = isDataValid.isNull(textPassword.Text);
            if(password)
            {
                errorMessagePassword.Text = "Invalid Password";
            }
            else
            {
                UserData.Add(User.Item4);
                UserData.Add(User.Item3);
                UserData.Add(textPassword.Text);

                foreach(var data in UserData)
                {
                    Console.WriteLine(data);
                }

                var UserId = getUser.LoginData(UserData);
                Console.WriteLine(UserId);
                if (UserId != 0)
                {
                    deleteAllData.DeleteUserData(Id);
                    deleteAllData.DeleteUserProfile(Id);
                    deleteAllData.DeleteUserClass(Id);

                    string message = "All Data Succesfully Deleted";
                    string title = "Continue to Login Form";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        Application.OpenForms["EditProfile"].Close();
                        Login form = new Login();
                        this.Close();
                        form.ShowDialog();
                    }
                    else
                    {
                        Application.Exit();
                    }
                    
                }
                else
                {
                    errorMessagePassword.Text = "Wrong Password, Please Try Again";
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using learnIT.Controller;
using learnIT.Data;
using learnIT.Forms;

namespace learnIT
{
    public partial class Register : Form
    {
        //list of string to store the validated data
        List<string> ValidData = new List<string>();

        //reference to UserDataAccess
        UserDataAccess sendData = new UserDataAccess();

        GetData setEmail = new GetData();

        public Register()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxConPassword.PasswordChar = '*';
            comboBoxRole.SelectedIndex = 0;
            resetErrorMessages();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //reference to isDataValid
            ValidateNewData isDataValid = new ValidateNewData();
            resetErrorMessages();
            //store the boolean of isNull(data)
            var lastName = isDataValid.isNull(textBoxLastName.Text);
            var firstName = isDataValid.isNull(textBoxFirstName.Text);
            var email = isDataValid.isNull(textBoxEmail.Text);
            var oldEmail = isDataValid.validEmail(textBoxEmail.Text);
            var password = isDataValid.isNull(textBoxPassword.Text);
            var conPassword = isDataValid.isNull(textBoxConPassword.Text);
            var userRole = isDataValid.isNull(comboBoxRole.Text);
           

            //check if data is empty and display error messages
            if (userRole || comboBoxRole.SelectedIndex == 0)
            {
                errorLabelRole.Text = "Please Select a Role";

            }
            else if (lastName)
            {
                errorLabelLastName.Text = "Invalid Last Name";
            }
            else if (firstName)
            {
                errorLabelFirstName.Text = "Invalid First Name";
            }
            else if (email)
            {
                errorLabelEmail.Text = "Invalid Email";
            }
            else if (oldEmail)
            {
                errorLabelEmail.Text = "Email Already In Used";
            }
            else if (password)
            {
                errorLabelPassword.Text = "Invalid Password";
            }
            else if (conPassword)
            {
                errorLabelConPassword.Text = "Invalid Confirm Password";
            }
            else if (textBoxPassword.Text != textBoxConPassword.Text)
            {
                textBoxPassword.ResetText();
                textBoxConPassword.ResetText();
                errorLabelPassword.Text = "Password needs to be the same";
                errorLabelConPassword.Text = "Password needs to be the same";

            }

            //if all data is not empty, store in the validData list and send data to UserDataAccess
            else
            {
                ValidData.Add(textBoxLastName.Text);    //ValidData[0]
                ValidData.Add(textBoxFirstName.Text);   //ValidData[1]
                ValidData.Add(textBoxEmail.Text);       //ValidData[2]
                ValidData.Add(textBoxPassword.Text);    //ValidData[3]
                ValidData.Add(comboBoxRole.Text);       //ValidData[4]


                sendData.SendUserDataToDatabase(ValidData);
                

                GettingStarted open = new GettingStarted(setEmail.getIdUsingEmail(textBoxEmail.Text), textBoxFirstName.Text);
                this.Hide();
                open.ShowDialog();                           
            }
        }

        private void resetErrorMessages()
        {
            errorLabelRole.ResetText();
            errorLabelLastName.ResetText();
            errorLabelFirstName.ResetText();
            errorLabelEmail.ResetText();
            errorLabelPassword.ResetText();
            errorLabelConPassword.ResetText();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}

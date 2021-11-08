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

namespace learnIT.Forms
{
    public partial class EditProfile : Form
    {
        ValidateNewData IsDataValid = new ValidateNewData();
        GetData GetProfile = new GetData();
        UserDataAccess UpdateData = new UserDataAccess();
        String UserEmail = "";
        int Id; 

        public EditProfile(int id)
        {
            InitializeComponent();
            errorMessages();
            Id = id;

            //Encrpyt password input
            textCurrentPassword.PasswordChar = '*';
            textPassword.PasswordChar = '*';
            textConPassword.PasswordChar = '*';

            //Set User Information text box
            var User = GetProfile.DashboardLogin(id);
            //item1 = first name
            textFirstName.Text = User.Item1;
            //item2 = last name
            textLastName.Text = User.Item2;
            //item3 = email
            UserEmail = User.Item3;
            textEmail.Text = User.Item3;

            //Set User Profile Text Box
            var UserProfile = GetProfile.GetProfile(id);
            //year level
            comboBoxYearLevel.SelectedItem = UserProfile.Item1;
            //birthdate
            textBirthdate.Value = Convert.ToDateTime(UserProfile.Item2);
            //gender
            if(UserProfile.Item3 == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
            //phone
            textPhone.Text = UserProfile.Item4.ToString();

            //Set User Address Text Box
            var UserAddress = GetProfile.GetAddress(id);
            //street
            textStreet.Text = UserAddress.Item1;
            //town
            textTown.Text = UserAddress.Item2;
            //province
            textProvince.Text = UserAddress.Item3;
            //zipcode
            textZipcode.Text = UserAddress.Item4.ToString();


            //set password to Nothing
            textPassword.Text = "********";
            textConPassword.Text = "********";

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            errorMessages();

            //validate user-data
            var lastName = IsDataValid.isNull(textLastName.Text);
            var firstName = IsDataValid.isNull(textFirstName.Text);
            var password = IsDataValid.isNull(textPassword.Text);
            var conPassword = IsDataValid.isNull(textConPassword.Text);

            //validate user profile
            var yearlevel = IsDataValid.isNull(comboBoxYearLevel.Text);
            //Convert the dateTime typre to string and set the format to year/month/date
            var birthday = IsDataValid.isNull(textBirthdate.Value.ToString("yyyy-MM-dd"));
            //Check if one of the radioButton is checked before checking if the value is null
            var gender = IsDataValid.isNull(IsDataValid.selectedGender(radioButtonMale.Checked, radioButtonFemale.Checked));
            //Check if the phone can be converted to long integer
            var phoneNotLong = IsDataValid.isDataNotLong(textPhone.Text);
            var phone = IsDataValid.isNull(textPhone.Text);

            //validate user address
            var street = IsDataValid.isNull(textStreet.Text);
            var town = IsDataValid.isNull(textTown.Text);
            var province = IsDataValid.isNull(textProvince.Text);
            //Check if the phone can be converted to integer
            var zipcode = IsDataValid.isNull(textZipcode.Text);
            var zipcodeNotInt = IsDataValid.isDataNotInt(textZipcode.Text);

            //check bool validate user if true
            if (firstName)
            {
                errorMessageFirstName.Text = "Invalid First Name";
            }
            else if (lastName)
            {
                errorMessageLastName.Text = "Invalid Last Name";
            }
            else if (password)
            {
                errorMessagePassword.Text = "Invalid Password";
            }
            else if (conPassword)
            {
                errorMessageConPassword.Text = "Confirm New Password";
            }
            else if (textPassword.Text != textConPassword.Text)
            {
                errorMessagePassword.Text = "Password do not Match";
                textPassword.ResetText();
                textConPassword.ResetText();
            }  
            //check bool validate user profile if true
            else if (yearlevel)
            {
                errorMessageYearLevel.Text = "Invalid Year Level";
            }
            else if (birthday)
            {
                errorMessageBirthday.Text = "Invalid Birthdate";
            }
            else if (gender)
            {
                errorMessageGender.Text = "Invalid Gender";
            }
            else if (phoneNotLong)
            {
                errorMessagePhone.Text = "Invalid Phone Number";
            }
            else if (phone)
            {
                errorMessagePhone.Text = "Phone Number is not a number";
            }
            //check bool validate user address if true
            else if (street)
            {
                errorMessageStreet.Text = "Invalid Street/Barangay";
            }
            else if (town)
            {
                errorMessageTown.Text = "Invalid Town/City";
            }
            else if (province)
            {
                errorMessageProvince.Text = "Invalid Province";
            }
            else if (zipcode)
            {
                errorMessageZipcode.Text = "Invalid ZipCode";
            }
            else if (zipcodeNotInt)
            {
                errorMessageZipcode.Text = "ZipCode is not a Number";
            }
            //if not update user info
            else if (textPassword.Text != "********" && textConPassword.Text != "********")
            {

                errorMessages();
                List<string> userEmailPassword = new List<String>();
               

                userEmailPassword.Add(textCurrentPassword.Text);
                userEmailPassword.Add(UserEmail);

                var UserAccess = GetProfile.EditDataConfig(userEmailPassword);
                if (UserAccess == 0)
                {
                    errorMessageCurrentPassword.Text = "Invalid Password";
                    textCurrentPassword.ResetText();
                }
                else
                {
                    UpdateProfileWithPassword();
                    UpdateUserProfile();
                }
            }
            else
            {

                errorMessages();
                List<string> userEmailPassword = new List<String>();


                userEmailPassword.Add(textCurrentPassword.Text);
                userEmailPassword.Add(UserEmail);

                var UserAccess = GetProfile.EditDataConfig(userEmailPassword);
                if (UserAccess == 0)
                {
                    errorMessageCurrentPassword.Text = "Invalid Password";
                    textCurrentPassword.ResetText();
                }
                else
                {
                    UpdateProfileWithoutPassword();
                    UpdateUserProfile();
                }
            }
        }

        private void UpdateProfileWithoutPassword()
        {
             List<string> editProfile = new List<string>();

             textCurrentPassword.ResetText();

             editProfile.Add(textLastName.Text); //0
             editProfile.Add(textFirstName.Text); //1

             UpdateData.UpdateAccessWithoutPassword(Id, editProfile);
    
        }

        private void UpdateProfileWithPassword()
        {
            List<string> editProfile = new List<string>();

            
            textCurrentPassword.ResetText();

            editProfile.Add(textLastName.Text); //0
            editProfile.Add(textFirstName.Text); //1
            editProfile.Add(textPassword.Text); //2

            UpdateData.UpdateAccessWithPassword(Id, editProfile);
    
        }

        private void UpdateUserProfile()
        {
            List<string> editUserProfile = new List<string>();


            textCurrentPassword.ResetText();

            editUserProfile.Add(comboBoxYearLevel.Text); //0
            editUserProfile.Add(textBirthdate.Value.ToString("yyyy-MM-dd")); //1
            editUserProfile.Add(IsDataValid.selectedGender(radioButtonMale.Checked, radioButtonFemale.Checked)); //2
            long Phone = Int64.Parse(textPhone.Text);

            //address
            editUserProfile.Add(textStreet.Text); //3
            editUserProfile.Add(textTown.Text); //4
            editUserProfile.Add(textProvince.Text); //5
            int Zipcode = Int32.Parse(textZipcode.Text);

            UpdateData.UpdateUserProfile(Id, editUserProfile, Phone, Zipcode);
        }

        private void errorMessages()
        {
            errorMessageFirstName.ResetText();
            errorMessageLastName.ResetText();
            errorMessagePassword.ResetText();
            errorMessageConPassword.ResetText();
            errorMessageCurrentPassword.ResetText();

            errorMessageYearLevel.ResetText();
            errorMessageBirthday.ResetText();
            errorMessageGender.ResetText();
            errorMessagePhone.ResetText();

            errorMessageStreet.ResetText();
            errorMessageTown.ResetText();
            errorMessageProvince.ResetText();
            errorMessageZipcode.ResetText();
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

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Profile form = new Profile(Id);
            this.Hide();
            form.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Profile form = new Profile(Id);
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
                AdminClass form = new AdminClass(Id);
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                StudentClass form = new StudentClass(Id);
                this.Hide();
                form.ShowDialog();
            }
        }
    }
}

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
    //Getting Started Form
    public partial class GettingStarted : Form
    {
        //UserDataReference to use in sending data to the database
        UserDataAccess sendProfile = new UserDataAccess();

        //List of integer to store the user's id, phone and zipcode
        List<int> UserProfileInt = new List<int>();
        
        //List of string to store the user's year level, gender, birthday and address 
        List<string> UserProfile = new List<string>();

        //Store the name of the user
        int GlobalId;

        //Main Form
        public GettingStarted(int id, string name)
        {
            InitializeComponent();

            //reset the error messages
            errorMessages();

            //add the id that is get by using the reference in the register form
            UserProfileInt.Add(id);                                                                           //index of id in the UserProfileInt is 0

            //Set the labelName to the string the is get by reference in the regiter form
            labelName.Text = name;

            //store the name to the global variable 
            GlobalId = id;


            Console.WriteLine(UserProfileInt[0]);
        }

        //Event handler for the submit button
        private void submitProfile_Click(object sender, EventArgs e)
        {
            //reset error messages
            errorMessages();

            //new reference to use the method in the ValidateNewMethod Class
            ValidateNewData validate = new ValidateNewData();

            // store a boolean data type to validate the inputted data by the users 
            var yearlevel = validate.isNull(comboBoxYearLevel.Text);
            //Convert the dateTime typre to string and set the format to year/month/date
            var birthday = validate.isNull(birthDate.Value.ToString("yyyy-MM-dd"));
            //Check if one of the radioButton is checked before checking if the value is null
            var gender = validate.isNull(validate.selectedGender(radioButtonMale.Checked, radioButtonFemale.Checked));
            //Check if the phone can be converted to long integer
            var phoneNotLong = validate.isDataNotLong(textBoxPhone.Text);
            var phone = validate.isNull(textBoxPhone.Text);
            var street = validate.isNull(textBoxStreet.Text);
            var town = validate.isNull(textBoxTown.Text);
            var province = validate.isNull(textBoxProvince.Text);
            //Check if the phone can be converted to integer
            var zipcode = validate.isNull(textBoxZipCode.Text);
            var zipcodeNotInt = validate.isDataNotInt(textBoxZipCode.Text);

            //if the value in the bolean data type is true, change the error messages label
            if (yearlevel)
            {
                errorLabelYearLevel.Text = "Invalid Year Level";
            }
            else if (birthday)
            {
                errorLabelBirthDate.Text = "Invalid Birthdate";
            }
            else if (gender)
            {
                errorLabelGender.Text = "Invalid Gender";
            }
            else if (phoneNotLong)
            {
                errorLabelPhone.Text = "Invalid Phone Number";
            }
            else if (phone)
            {
                errorLabelPhone.Text = "Phone Number is not a number";
            }
            else if (street)
            {
                errorLabelStreet.Text = "Invalid Street/Barangay";
            }
            else if (town)
            {
                errorLabelTown.Text = "Invalid Town/City";
            }
            else if (province)
            {
                errorLabelProvince.Text = "Invalid Province";
            }
            else if (zipcode)
            {
                errorLabelZipcode.Text = "Invalid ZipCode";
            }
            else if(zipcodeNotInt)
            {
                errorLabelZipcode.Text = "ZipCode is not a Number";
            }
            //if all data is valid, send data to the database
            else
            {
                //Add the valid phone to the list UserProfileInt
                UserProfileInt.Add(Int32.Parse(textBoxZipCode.Text));                                           //the index of phone in the UserProfileInt 1

                //Add all the valid datas to the list UserProfile
                UserProfile.Add(comboBoxYearLevel.Text);                                                        //the index of phone in the UserProfile 0
                UserProfile.Add(birthDate.Value.ToString("yyyy-MM-dd"));                                        //the index of phone in the UserProfile 1
                UserProfile.Add(validate.selectedGender(radioButtonMale.Checked, radioButtonFemale.Checked));   //the index of phone in the UserProfile 2
                UserProfile.Add(textBoxStreet.Text);                                                            //the index of phone in the UserProfile 3
                UserProfile.Add(textBoxTown.Text);                                                              //the index of phone in the UserProfile 4
                UserProfile.Add(textBoxProvince.Text);                                                          //the index of phone in the UserProfile 5

                //Store the valid phone number to a Long integer
                long Phone = Int64.Parse(textBoxPhone.Text);

                //send all the stored data to the database
                //it will go first to the UserDataAccess Class before going to the SqlQuery Class where all the query strings are stored
                sendProfile.SendUserProfileToDatabase(UserProfile, UserProfileInt, Phone);

                //Reference to a new dashboard form and send the first name of the user
                Dashboard dash = new Dashboard(GlobalId);
                //hide the current form
                this.Hide();
                //Open the dashboard form
                dash.ShowDialog();
            }
 
        }

        //reset the textbox for all the error message labels
        private void errorMessages()
        {
            errorLabelYearLevel.ResetText();
            errorLabelBirthDate.ResetText();
            errorLabelGender.ResetText();
            errorLabelPhone.ResetText();
            errorLabelStreet.ResetText();
            errorLabelTown.ResetText();
            errorLabelProvince.ResetText();
            errorLabelZipcode.ResetText();
        }

    }
}

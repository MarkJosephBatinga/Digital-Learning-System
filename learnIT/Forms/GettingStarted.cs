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
    public partial class GettingStarted : Form
    {
        UserDataAccess sendProfile = new UserDataAccess();
        List<int> UserProfileInt = new List<int>();
        List<string> UserProfile = new List<string>();
        string Globalname = "";

        public GettingStarted(int id, string name)
        {
            InitializeComponent();
            errorMessages();
            UserProfileInt.Add(id);
            labelName.Text = name;
            Globalname = name;
            Console.WriteLine(UserProfileInt[0]);
        }

        private void submitProfile_Click(object sender, EventArgs e)
        {
            GetData getId = new GetData();
            errorMessages();


            ValidateNewData validate = new ValidateNewData();

            var yearlevel = validate.isNull(comboBoxYearLevel.Text);
            var birthday = validate.isNull(birthDate.Value.ToString("yyyy-MM-dd"));
            var gender = validate.isNull(validate.selectedGender(radioButtonMale.Checked, radioButtonFemale.Checked));
            var phone = validate.isDataNotLong(textBoxPhone.Text);
            var street = validate.isNull(textBoxStreet.Text);
            var town = validate.isNull(textBoxTown.Text);
            var province = validate.isNull(textBoxProvince.Text);
            var zipcode = validate.isDataNotInt(textBoxZipCode.Text);

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
            else if (phone)
            {
                errorLabelPhone.Text = "Invalid Phone Number";
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
                try
                {
                    int ZipCodeInt = Int32.Parse(textBoxZipCode.Text);
                    Console.WriteLine(ZipCodeInt);
                }
                catch (FormatException)
                {
                    errorLabelPhone.Text = "ZipCode needs to be a Number";
                }
                errorLabelZipcode.Text = "Invalid ZipCode";
            }
            else
            {
                UserProfileInt.Add(Int32.Parse(textBoxZipCode.Text)); //1

                UserProfile.Add(comboBoxYearLevel.Text); //0
                UserProfile.Add(birthDate.Value.ToString("yyyy-MM-dd")); //1
                UserProfile.Add(validate.selectedGender(radioButtonMale.Checked, radioButtonFemale.Checked)); //2
                UserProfile.Add(textBoxStreet.Text); //3
                UserProfile.Add(textBoxTown.Text); //4
                UserProfile.Add(textBoxProvince.Text); //5

                long Phone = Int64.Parse(textBoxPhone.Text);

                sendProfile.SendUserProfileToDatabase(UserProfile, UserProfileInt, Phone);
                Dashboard dash = new Dashboard(Globalname);
                Hide();
                dash.ShowDialog();
            }
 
        }
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

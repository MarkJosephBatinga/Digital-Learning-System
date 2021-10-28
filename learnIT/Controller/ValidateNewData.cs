using learnIT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Controller
{
    //Help in validating the inputted data in both register form and getting started form
    class ValidateNewData
    {
        //Check if the data is empty or only consist of whitespace
       public bool isNull(string data)
        {
            if(String.IsNullOrWhiteSpace(data))
            {
                //if the data is empty return true
                return true;
            }
            else
            {
                //if the data is not empty return false
                return false;
            }
        }
        //Validate the radio button for gender
        public string selectedGender(bool checkedMale, bool checkedFemale)
        {
            if(checkedMale)
            {
                //if the Male radio button is checked return the Male string
                return "Male";
            }
            else if(checkedFemale)
            { 
                //if the Female radio button is checked return the Female string
                return "Female";
            }
            else
            {
                //if both is not checked return null or empty string;
                return null;
            }
        }

        //Validate the email inputted if the email already in used in the database
        public bool validEmail(string inputedEmail)
        {
            //new reference to UserDataAccess class to use the search for email method
           UserDataAccess search = new UserDataAccess();
            //Store the data in a new user reference list
           List<UserData> dataSearch = search.SearchForEmail(inputedEmail);
           foreach(var data in dataSearch)
            {
                //store the email in a value
                string emailSearch = data.email.ToString();
                if(emailSearch == null)
                {
                    //if emailSearch is null meaning the email is not in the database
                    return false;
                }
                else
                {
                    //if emailSearch is not empty the email is already in used at the database
                    return true;
                }
            }
           //return a default null
            return false;
        }

        //Check if the inputted data in the zipcode TextBox is a integer
        public bool isDataNotInt(string data)
        {
            //Catch a format exepction if the string cannot be converted to int
            try
            {
                //return false if convertion is a success
                int ZipCodeInt = Int32.Parse(data);
                return false;
            }
            catch (FormatException)
            {
                //return true if string cannot convert into int
                return true;
            }
        }

        //Check if the inputted data in the phone textbox is a long integer
        public bool isDataNotLong(string data)
        {
            //Catch a format exepction if the string cannot be converted to long
            try
            {
                //return false if convertion is a success
                long ZipCodeInt = Int64.Parse(data);
                return false;
            }
            catch (FormatException)
            {
                //return true if string cannot convert into long integer
                return true;
            }
        }
    }
}

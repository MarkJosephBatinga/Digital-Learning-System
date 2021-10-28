using learnIT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Controller
{
    class ValidateNewData
    {
        //Check if the unvalidated data is empty
       public bool isNull(string data)
        {
            if(String.IsNullOrWhiteSpace(data))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string selectedGender(bool checkedMale, bool checkedFemale)
        {
            if(checkedMale)
            {
                return "Male";
            }
            else if(checkedFemale)
            {
                return "Female";
            }
            else
            {
                return null;
            }
        }

        public bool validEmail(string inputedEmail)
        {
           UserDataAccess search = new UserDataAccess();
           List<UserData> dataSearch = search.SearchForEmail(inputedEmail);
           foreach(var data in dataSearch)
            {
                string emailSearch = data.email.ToString();
                if(emailSearch == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public bool isDataNotInt(string data)
        {
            try
            {
                int ZipCodeInt = Int32.Parse(data);
                return false;
            }
            catch (FormatException)
            {
                return true;
            }
        }
        public bool isDataNotLong(string data)
        {
            try
            {
                long ZipCodeInt = Int64.Parse(data);
                return false;
            }
            catch (FormatException)
            {
                return true;
            }
        }
    }
}

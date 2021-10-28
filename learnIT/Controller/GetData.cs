using learnIT.Data;
using learnIT.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Controller
{
    //Get data from the database
    class GetData
    {
        //reference to a new UserDataAccess Class
        UserDataAccess getId = new UserDataAccess();
        //New list of User Data
        List<UserData> getDataUsingEmail = new List<UserData>();

        // return the id
        public int getIdUsingEmail(string email)
        {
            //store the returned id from GetUSerID method to the new list od UserData
            getDataUsingEmail = getId.GetUserId(email);
            //check if the list is not empty and return the id
            foreach(var data in getDataUsingEmail)
            {
                return data.id;
            }
            //default value return 0;
            return 0;
        }

        
    }
}

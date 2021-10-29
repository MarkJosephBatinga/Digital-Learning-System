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
        UserDataAccess DatabaseAccess = new UserDataAccess();
        //New list of User Data
        List<UserData> User = new List<UserData>();

        // return the id
        public int getIdUsingEmail(string email)
        {
            //store the returned id from GetUSerID method to the new list od UserData
            User = DatabaseAccess.GetUserId(email);
            //check if the list is not empty and return the id
            foreach(var data in User)
            {
                return data.id;
            }
            //default value return 0;
            return 0;
        }

        // return the id
        public int LoginData(List<string> InputtedUser)
        {
            //store the returned id from GetUSerID method to the new list od UserData
            User = DatabaseAccess.LoginAccess(InputtedUser);
            //check if the list is not empty and return the id
            foreach (var data in User)
            {
                int GetId = data.id;
                return GetId;
            }
            //default value return 0;
            return 0;
        }

        // return the id
        public Tuple<string> DashboardLogin(int id)
        {
            //store the returned id from GetUSerID method to the new list od UserData
            User = DatabaseAccess.DashboardAccess(id);
            //check if the list is not empty and return the id
            foreach (var data in User)
            {
                var User = Tuple.Create(data.first_name);
                return User;
            }
            //default value return 0;
            return null;
        }
    }
}

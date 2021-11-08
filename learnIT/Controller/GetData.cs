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
        //new list of user profile
        List<UserProfile> UserProfile = new List<UserProfile>();

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

        // return the User in the user_table
        public Tuple<string, string, string, string> DashboardLogin(int id)
        {
            //store the returned id from GetUSerID method to the new list od UserData
            User = DatabaseAccess.DashboardAccess(id);
            //check if the list is not empty and return the id
            foreach (var data in User)
            {
                var User = Tuple.Create(data.first_name, data.last_name, data.email, data.user_role);
                return User;
            }
            //default value return 0;
            return null;
        }

        // return the User Profile in the user_Profile
        public Tuple<string, string, string, long> GetProfile(int id)
        {
            //store the returned id from GetUSerID method to the new list od UserData
            UserProfile = DatabaseAccess.ProfileAccess(id);
            //check if the list is not empty and return the id
            foreach (var data in UserProfile)
            {
                var User = Tuple.Create(data.year_level, data.birth_date, data.gender, data.phone);
                return User;
            }
            //default value return 0;
            return null;
        }

        // return the User Profile in the user_Profile
        public Tuple<string, string, string, int> GetAddress(int id)
        {
            //store the returned id from GetUSerID method to the new list od UserData
            UserProfile = DatabaseAccess.ProfileAccess(id);
            //check if the list is not empty and return the id
            foreach (var data in UserProfile)
            {
                var User = Tuple.Create(data.add_street, data.add_town, data.add_province, data.add_zipcode);
                return User;
            }
            //default value return 0;
            return null;
        }

        // return the email and password
        public int EditDataConfig(List<string> InputtedUser)
        {
            //store the returned id from GetUSerID method to the new list od UserData
            User = DatabaseAccess.EditDataAccess(InputtedUser);
            //check if the list is not empty and return the id
            foreach (var data in User)
            {
                int GetId = data.id;
                return GetId;
            }
            //default value return 0;
            return 0;
        }
    }
}

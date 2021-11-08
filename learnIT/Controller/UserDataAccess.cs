using Dapper;
using learnIT.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using learnIT.SqlQueries;

namespace learnIT.Controller
{

    //Main Access point of the databse learnIt
    //The using statement inside the method is to automatically open and close the connection
    public class UserDataAccess
    {
        //Update Profile in the User Profile
        public void UpdateUserProfile(int id, List<string> User, long phone, int zipcode)
        {

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserProfile>(SendDataQuery.UpdateUserProfileQuery(id, User, phone, zipcode)).ToList();
                Console.WriteLine("Update User Profile Successfull");
            }
        }


        //Update Profile in the User Table
        public void UpdateAccessWithPassword(int id, List<string> User)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserData>(SendDataQuery.UpdateQueryWithPassword(id, User)).ToList();
                Console.WriteLine("Update Successfull");
            }
        }

        //Update Profile in the User Table
        public void UpdateAccessWithoutPassword(int id, List<string> User)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserData>(SendDataQuery.UpdateQueryWithoutPassword(id, User)).ToList();
                Console.WriteLine("Update Successfull");
            }
        }

        //Access To Get The Password for Edit Profile Form
        public List<UserData> EditDataAccess(List<string> User)
        {
            List<UserData> EditUser = new List<UserData>();

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                EditUser = conn.Query<UserData>(SendDataQuery.EditDataQuery(User)).ToList();
                Console.WriteLine("Edit Data Search Successfull");
                return EditUser;
            }
        }

        //Login Access
        public List<UserData> LoginAccess(List<string> User)
        {
            List<UserData> LoginUser = new List<UserData>();

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                LoginUser = conn.Query<UserData>(SendDataQuery.LoginQuery(User)).ToList();
                Console.WriteLine("Login Search Successfull");
                return LoginUser;
            }
        }

        //Dashboard Access
        public List<UserData> DashboardAccess(int id)
        {
            List<UserData> LoginUser = new List<UserData>();

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                LoginUser = conn.Query<UserData>(SendDataQuery.DashBoardQuery(id)).ToList();
                Console.WriteLine("Dashboard login Successfull");
                return LoginUser;
            }
        }

        //Profile Access
        public List<UserProfile> ProfileAccess(int id)
        {
            List<UserProfile> LoginUser = new List<UserProfile>();

            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                LoginUser = conn.Query<UserProfile>(SendDataQuery.ProfileQuery(id)).ToList();
                Console.WriteLine("Dashboard login Successfull");
                return LoginUser;
            }
        }

        //Send the validated user data that is inputed in the register form to the database
        public void SendUserDataToDatabase(List<string> User)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserData>(SendDataQuery.SendDataQueryString(User)); 
                Console.WriteLine("Added Successfully");
            }
        }

        //Send the validated data that is inputed in the getting started form to the database
        public void SendUserProfileToDatabase(List<string> UserProfile, List<int> UserProfileInt, long phone)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                conn.Query<UserProfile>(SendDataQuery.SendDataProfileQuery(UserProfile, UserProfileInt, phone));
                Console.WriteLine("Added Successfully");
            }
        }

        //Get the primary key of the user_table using the email inputted in the register form
        public List<UserData> GetUserId(string email)
        {
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                var output = conn.Query<UserData>(SendDataQuery.GetIdQuery(email)).ToList();
                Console.WriteLine("Succesfully searched for id using email in the database");
                return output;
            }
        }

        //Search for all the email in the database to check if the inputted email in the register form is already existed
        public List<UserData> SearchForEmail(string email)
        {
            //Store all the searchedEmail in a list of UserData
            List<UserData> searchedEmail = new List<UserData>();
            //open the connection string to connect to the database
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(Helper.ConnValue("database")))
            {
                //Create a new Query and get the string query from Sql Queries 
                searchedEmail = conn.Query<UserData>(SendDataQuery.SearchEmail(email)).ToList();
                Console.WriteLine("Successfully searched for email in the database");
                return searchedEmail;
            }
        }
    }
}

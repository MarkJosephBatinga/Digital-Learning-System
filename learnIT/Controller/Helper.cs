using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Controller
{
    //return the connection string that is located in the app.config file
    public static class Helper
    {
        public static string ConnValue(string databaseName)
        {
            //Get the Connection String from app.config
            return ConfigurationManager.ConnectionStrings[databaseName].ConnectionString;
        }
    }
}

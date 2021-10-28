using learnIT.Data;
using learnIT.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Controller
{
    class GetData
    {
        UserDataAccess getId = new UserDataAccess();
        List<UserData> getDataUsingEmail = new List<UserData>();

        public int getIdUsingEmail(string email)
        {
            getDataUsingEmail = getId.GetUserId(email);
            foreach(var data in getDataUsingEmail)
            {
                return data.id;
            }
            return 0;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Class
{
    class ValidateClass
    {
        public bool IsClassNull(string data)
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
    }
}

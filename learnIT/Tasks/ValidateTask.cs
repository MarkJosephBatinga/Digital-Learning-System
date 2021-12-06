using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.TasksForm
{
    class ValidateTask
    {
        public bool IsTaskNull(string data)
        {
            if (String.IsNullOrWhiteSpace(data))
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

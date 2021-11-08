using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.SqlQueries
{
    class ClassQuery
    {
        public static string CreateNewClass(int id, List<string> Class)
        {
            string title = Class[0];
            string section = Class[1];
            string code = Class[2];
            string description = Class[3];
            return $"INSERT INTO user_class(class_title, class_section, class_code, class_description, class_creator) VALUES('{title}', '{section}', '{code}', '{description}', {id});";
        }
    }
}

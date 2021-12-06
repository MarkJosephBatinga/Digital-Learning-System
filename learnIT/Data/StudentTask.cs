using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Data
{
    class StudentTask
    {
        //id
        public int student_task_id { get; set; }
        //student_class_id
        public int student_class_id { get; set; }
        //student_pass
        public string student_pass { get; set; }
        //student_grade
        public int student_grade { get; set; }
        //date_passed
        public string date_passed { get; set; }
        //student pdf name
        public string pdf_name { get; set; }
        //pdf_path
        public string pdf_path { get; set; }
        //task_id
        public int user_task_id { get; set; }
    }
}

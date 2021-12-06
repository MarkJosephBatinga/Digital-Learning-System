using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnIT.Data
{
    class UserTask
    {
        //task_id
        public int task_id { get; set; }
        //class_id
        public int class_id { get; set; }
        //cur_date
        public string cur_date { get; set; }
        //task_title
        public string task_title { get; set; }
        //task_type
        public string task_type { get; set; }
        //task_date
        public string task_date { get; set; }
        //task_time
        public string task_time { get; set; }
        //task_filename
        public string task_filename { get; set; }
        //task_filepath
        public string task_filepath { get; set; }
        //task_description
        public string task_description { get; set; }
    }
}

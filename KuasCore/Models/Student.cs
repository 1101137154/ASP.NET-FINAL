using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuasCore.Models
{
    public class Student
    {
        public int id { get; set; }

        public string stu_id { get; set; }

        public string stu_name { get; set; }

        public string stu_phone { get; set; }

        public DateTime stu_birth { get; set; }

        public string stu_info { get; set; }

        public override string ToString()
        {
            return "Student: Id = " + stu_id + ", Name = " + stu_name + ".";
        }
    }
}

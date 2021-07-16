using System;
using System.Collections.Generic;
using System.Text;

namespace onetoone
{
    class Department
    {
        public string dpName { set; get; }

        public string fulname { set; get; }
        public List<Student> students { set; get; }


        public Department()
        {
            students = new List<Student>();
        }
    }
}


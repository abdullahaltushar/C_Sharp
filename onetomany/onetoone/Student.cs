using System;
using System.Collections.Generic;
using System.Text;

namespace onetoone
{
    class Student
    {
        public string RgNo { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }


        public Address PresentAddress { set; get; }
    }
}

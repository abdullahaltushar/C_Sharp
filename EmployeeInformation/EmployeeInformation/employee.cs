using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    class employee
    {

        public string firstName;
        public string middleName;
        public string LastName;

        public string GetFullName()
        {

            string fullname = firstName + " " + middleName + " " + LastName;
            return fullname;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public int  id;

        public Person()
        {
            id = 1729004;

        }

        public Person(string firstName,string lastName):this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public Person(string firstName, string middleName, string lastName)
            :this(firstName,lastName)
        {

          //  this.firstName = firstName;
            this.middleName = middleName;
            // this.lastName = lastName;
        }


        public string GetFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName+" being"+ id;
            return fullName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

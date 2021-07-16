using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Person personOne = new Person("abdullah","al","tushar");
            //personOne.firstName = "Abdulah";
            //personOne.middleName = "al";
          //  personOne.lastName = "tushar";

            string fullname = personOne.GetFullName();
            string reverseName = personOne.GetReverseName();
            Console.WriteLine(fullname);
            Console.WriteLine(reverseName);
           
        }
    }
}

using System;

namespace onetoone
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address();
            address1.AptNo = "house12";
            address1.HouseNo = "57";
            address1.RoadNo = "1";

            Student student = new Student();
            student.Name = "Harunur Roshid";
            student.Email = "abc@gmail.com";
            student.RgNo = "1729004";
            

            student.PresentAddress = address1;
           


            string sName = student.Name;
            Address saddress = student.PresentAddress;
            string Shoseno = student.PresentAddress.HouseNo;

            Student student1 = new Student();
            student1.Name = "abdullah";
            student1.Email = "abdullah@gmail.com";
            student1.RgNo = "1729005";

            Student student3 = new Student();
            student3.Name = "tushar";
            student3.Email = "tushar@gmail.com";
            student3.RgNo = "1729006";


            Department department = new Department();
            department.dpName = "CSE";
            department.fulname = "Computer Scince Eng";
            department.students.Add(student);
            department.students.Add(student1);
            department.students.Add(student3);

            student1.PresentAddress = address1;
            student3.PresentAddress = address1;


            Console.WriteLine(department.students.Count);
            Console.WriteLine(department.dpName);

            foreach(Student deptstudent in department.students)
            {

                string info = deptstudent.Name + " " + deptstudent.Email + " " + deptstudent.RgNo;
                string info1 = deptstudent.PresentAddress.AptNo + "" + deptstudent.PresentAddress.HouseNo;

                Console.WriteLine(info);
                Console.WriteLine(info1);
            }

          
        }
    }

}

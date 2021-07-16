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

            Console.WriteLine(sName + " " + saddress.RoadNo + " " + Shoseno);
           
        }
    }
}

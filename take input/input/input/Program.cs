using System;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Please Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("I am " + name + " I am " + age + " old!");
        }
    }
}

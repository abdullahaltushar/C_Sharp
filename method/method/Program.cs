using System;

namespace method
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Add(5, 6));
        }


        static int Add(int firstnumber, int secondnumber)
        {
            int result = firstnumber + secondnumber;
            return result;
        }
    }
}

using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] name = new string[5];
            name[0] = "Harunur Roshid";
            name[1] = "Tushar";
            name[2] = "Abdullah";
            name[3] = "Abdullah al tushar";
            name[4] = "Unknown";


            int[] number = new int[3];

            number[0] = 1;
            number[1] = 2;
            number[2] = 3;


            double[] value = new double[2] { 23.0, 5.12 };

            Console.WriteLine(name[3]);
            Console.WriteLine(number[2]);
            Console.WriteLine(value[1]);

        
        }
    }
}

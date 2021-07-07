using System;

namespace forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("new array work");


            int size = 20;

            int[] number =new int[size];
            for(int i=1; i<=size; i++)
            {
                number[i - 1] = i;
            }

            for (int i = 0; i < size; i++)
            {
                int aNumber = number[i];

                if (aNumber % 2 == 0)
                {
                    Console.WriteLine(aNumber);
                }

            }

        }
    }
}

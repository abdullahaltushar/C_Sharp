using System;

namespace Whileloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                if (i>4)
                {
                   
                    break;
                }

                i++;
            }


            Console.WriteLine("new program");



            while (i <= 20)
            {
                i++;
                if (i % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }






        }
    }
}

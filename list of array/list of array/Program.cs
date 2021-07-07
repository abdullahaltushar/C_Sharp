using System;
using System.Collections;

namespace list_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            arraylist.Add(123);
            arraylist.Add('A');
            arraylist.Add("ABC");
            arraylist.Add(123.5);
            Console.WriteLine(arraylist.Count);
            Console.WriteLine(arraylist.Contains(123));
            foreach(var data in arraylist)
            {
                Console.WriteLine(data);
            }


            arraylist.Remove(123);
            Console.WriteLine(arraylist.Count);
            foreach (var data in arraylist)
            {
                Console.WriteLine(data);
            }
            arraylist.RemoveAt(0);
            Console.WriteLine(arraylist.Count);
            foreach (var data in arraylist)
            {
                Console.WriteLine(data);
            }
            arraylist.RemoveRange(1, 1);
            Console.WriteLine(arraylist.Count);
            foreach (var data in arraylist)
            {
                Console.WriteLine(data);
            }
        }
    }
}

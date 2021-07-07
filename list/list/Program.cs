using System;
using System.Collections;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = new List<string>();
            mylist.Add("Am");
            mylist.Add("is");
            mylist.Add("are");
            Console.WriteLine(mylist.Count);

            List<string> newlist = new List<string>();
            mylist.Add("was");
            mylist.Add("were");
            mylist.Add("our");
            mylist.AddRange(newlist);

            Console.WriteLine(mylist.Count);

            foreach(var data in mylist)
            {
                Console.WriteLine(data);
            }

        }
    }
}

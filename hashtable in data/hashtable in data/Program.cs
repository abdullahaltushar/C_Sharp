using System;
using System.Collections;
using System.Collections.Generic;

namespace hashtable_in_data
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashinfo = new Hashtable();
            hashinfo.Add("1", 1000);
            hashinfo.Add("2", 2000);
            hashinfo.Add("3", 3000);
            hashinfo.Add("4", 4000);



            foreach(DictionaryEntry dictionaryEntry in hashinfo)
            {
                Console.WriteLine(dictionaryEntry.Key + " salary  " + dictionaryEntry.Value + "$");
            }

            Console.WriteLine(hashinfo.Count);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> myvalue = new Dictionary<string, double>();
            myvalue.Add("abe", 123);
            myvalue.Add("def", 456);
            myvalue.Add("ghi", 789);


            foreach(KeyValuePair<string,double> valueindata in myvalue)
            {
                Console.WriteLine(valueindata.Key + "  " + valueindata.Value);
            }
        }
    }
}

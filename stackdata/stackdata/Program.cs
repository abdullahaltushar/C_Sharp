using System;

using System.Collections;
using System.Collections.Generic;

namespace stackdata
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> mystack = new Stack<string>();
            mystack.Push("am");
            mystack.Push("is");
            mystack.Push("are");
            foreach( var data in mystack)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(mystack.Count);
            mystack.Pop();
            foreach (var data in mystack)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(mystack.Count);





            Console.WriteLine("start queue");

            Queue<string> myqueue = new Queue<string>();
            myqueue.Enqueue("abc");
            myqueue.Enqueue("def");
            myqueue.Enqueue("ijk");
            myqueue.Enqueue("lmn");

            foreach (var data in myqueue)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(myqueue.Count);
            myqueue.Dequeue();
            foreach (var data in myqueue)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(myqueue.Count);


        }
    }
}

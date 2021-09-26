using System;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new StackA();
            ls.Display();
            ls.Push(10);
            ls.Display();

            var rand = ls.Pop();
            Console.WriteLine(rand);
            ls.Display();

            ls.Push(10);  
            ls.Push(20);  
            ls.Push(30);  
            ls.Push(40);
            Console.WriteLine(ls);  

            var item = ls.Pop();
            Console.WriteLine(item);
            Console.WriteLine(ls);
        }
    }
}

using System;
using System.Collections.Generic;

namespace PracticeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>(){"Ravi", "Pardhu", "Harsha"};
            var linkedList = new LinkedList<string>(names);
            var firstName = linkedList.First;
            Console.WriteLine("First name" + firstName);
            foreach (var name in linkedList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("My own DoublyCircularLinkedList");
            Console.WriteLine();


            var newDCLL = new DoublyCircularLinkedList();

            newDCLL.Traverse();
            newDCLL.Traverse();

            newDCLL.CreateDLL(10);
            newDCLL.Traverse();

            for (var i = 0; i < 5; i++)
            {
                newDCLL.Add(i);
            }
            newDCLL.Traverse();



            newDCLL.Add(100, 0);
            newDCLL.Traverse();

            newDCLL.Delete(-1);
            newDCLL.Traverse();

            newDCLL.DeleteHead();
            newDCLL.DeleteHead();
            newDCLL.Traverse();
            Solutions();

        }
        static void Solutions()
        {
            var anotherDCLL = new  DoublyCircularLinkedList();
            for (var i = 0; i < 6; i++)
            {
                anotherDCLL.Add(i);
            }
            System.Console.Write("AnotherDCLL: ");
            anotherDCLL.Traverse();
            System.Console.WriteLine("Length of this LinkedList: "+ anotherDCLL.Length);
            Challenges.ReturnKthLast(anotherDCLL, 2);
            Challenges.ReturnKthLast(anotherDCLL, 6);
            Challenges.ReturnKthLast(anotherDCLL, 2);


        }
    }
}

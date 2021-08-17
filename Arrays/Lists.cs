using System;
using System.Collections.Generic;

namespace Arrays
{
    public class AboutLists
    {
        public void printList(List<int> myList)
        {
            foreach (var i in myList)
                System.Console.WriteLine(i);
        }


        public void Lists()
        {
            System.Console.WriteLine("This is all about Lists from now.");
            var integers = new List<int>();

            var newIntegers = new List<int>(){1, 2, 3, 4};

            // .Add() method to add something to the list
            newIntegers.Add(5);

            foreach (var  i in newIntegers)
                System.Console.WriteLine(i);


            System.Console.WriteLine("Adding from an array/list");
            // .AddRange() method to add a range of numbers
            newIntegers.AddRange(new int[3]{6, 7, 8});   
            foreach (var i in newIntegers)
                System.Console.WriteLine(i);


            // .IndexOf() method to get the index
            var index = newIntegers.IndexOf(7);
            System.Console.WriteLine("Index of 7:" +index);


            // .LastIndexOf() method to get the last index of the occurrence of the element
            newIntegers.Add(3);
            var lastIndex = newIntegers.LastIndexOf(3);
            System.Console.WriteLine(" Last Occurrence of 3: "+ lastIndex);


            // .Count is a property. Returns the number of objects in the list
            System.Console.WriteLine(newIntegers.Count);


            // .Remove() method
            newIntegers.Remove(3);      // removes the first occurrence of  3
            foreach (var  i in newIntegers)
                System.Console.WriteLine(i);

            
            newIntegers.Add(6);
            // to remove all 6's
            // You are not allowed to use a foreach loop when u want to modify the collection that u are enumerating over

            for (var i = 0; i < newIntegers.Count; i++)
            // foreach ( var i in newIntegers)
            {
                if (newIntegers[i] == 6)
                    newIntegers.Remove(newIntegers[i]);
            }
            System.Console.WriteLine("Iterating through the list after removing all 6's");
            foreach (var i in newIntegers)
                System.Console.WriteLine(i);


            // .Clear() method. Removes all elements from the list
            System.Console.WriteLine("Now trying to clear the integers list");
            integers.AddRange(new int[]{1,2,3,4,5,6});
            System.Console.WriteLine(integers.Count);

            integers.Clear();
            System.Console.WriteLine(integers.Count);

            


        }

    }
}
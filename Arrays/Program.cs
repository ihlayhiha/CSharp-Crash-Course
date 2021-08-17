using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var normalArray = new[]{1, 2, 3, 4, 5};

            // Initializing a rectangular array
            var matrix = new int[3, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 14, 15, 15}
            }
            ;
            foreach (var i in matrix)
                System.Console.WriteLine(i);
            System.Console.WriteLine(matrix[1,3]);


            // Initializing a Jagged array
            var array = new int[3][];
            array[0] = new int[4]{1, 2, 3, 4};            
            array[1] = new int[5]{11, 22, 33, 44, 55};            
            array[2] = new int[3]{111, 222, 333};      

            foreach (var row in array)   
                foreach(var j in row)   
                    System.Console.WriteLine(j);
            

            // .Length ---- returns the size of the  array
            System.Console.WriteLine("Length of matrix: " + matrix.Length);
            System.Console.WriteLine("Length of jagged array: " + array.Length);


            // Array.IndexOf() -- returns the index position of element in the array
            // Only supports single dimension arrays
            System.Console.WriteLine("Index position of {0} in normalArray is {1}", 3, Array.IndexOf(normalArray, 5));


            // Array.Clear()  method
            // 3 parameters. 1st - array, 2nd - starting index value, 3rd - length (how many values you want to clear)
            // Clearing means setting the items to the respective type's default values
            Array.Clear(normalArray, 0, 2);
            System.Console.WriteLine("Effect of clear method used on the first 2 elements:");
            foreach (var i in normalArray)
                System.Console.WriteLine(i);

            
            // Array.Copy() method
            // needs 3 parameters, 1st Array, 2nd new array where we want to copy  to, 3rd length (how many elements you are copying)
            var copiedArray = new int[3];
            Array.Copy(normalArray, copiedArray, 3);
            System.Console.WriteLine("This is the copied array");
            foreach(var  i in copiedArray)
                System.Console.WriteLine(i);


            // Array.Sort() method
            // changes the original array and sorts it
            Array.Sort(normalArray);
            System.Console.WriteLine("Using Array.Sort() method on normalArray");
            foreach (var i in normalArray)
                System.Console.WriteLine(i);


            // Array.Reverse() method
            // reverses the array
            Array.Reverse(normalArray);
            System.Console.WriteLine("Reversing the array");
            foreach (var  i in normalArray)
                System.Console.WriteLine(i);

        }
    }
}

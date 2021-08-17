using System;

namespace ValueType_and_Ref_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            // a and b are now completely independent as the value of a is copied and stored in a new stack memory with 'b' assigned to it
            // Hence, we call them valuetypes. Their values get copied and stored in someplace else in the memory
            // value of b is going to be 10 because integers are valuetypes 
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            

            var array1 = new int[3]{1, 2, 3};
            var array2 = array1;
            array2[0] = 0;

            // if u change the value of first element in array2, value of first element also changes in array1
            Console.WriteLine($"array1: {string.Join(", ", array1)}\narray2: {string.Join(", ", array2)}");
            Console.WriteLine(string.Format("Array1: {0}\nArray2: {0}", string.Join(", ", array1), string.Join(", ", array2)));

        }
    }
}

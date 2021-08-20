using System;
using Access_Modifiers.Amazon;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var newCustomer = new NewCustomer();

            RatingCalculator calculator = new RatingCalculator();
            System.Console.WriteLine(calculator.Calculate(newCustomer));

            var stack = new Stack();
            stack.Push(1);
            stack.Push("This is the middle element");
            stack.Push(33);
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());

            for (var i = 0; i < 10; i++ )
                stack.Push(i);
            
            System.Console.WriteLine("Printing out stack elements after iteration");
            System.Console.WriteLine(stack.Pop());
            
            System.Console.WriteLine("Clearing stack elements");
            stack.Clear();

            try
            {
                stack.Pop();
            }
            catch (System.Exception)
            {
                
                System.Console.WriteLine("This stack is already empty, so nothing Pops.");
            }

            
        }
    }
}

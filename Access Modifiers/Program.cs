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
        }
    }
}

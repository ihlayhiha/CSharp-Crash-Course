using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            int  i = 1;
            while (i <= 10)
            {
                System.Console.WriteLine($"value of i: {i}");
                i ++;
            }
            int jesus=0;
            for (var j =0; j < 22; j ++)
            {
                System.Console.WriteLine($"value of j: {j}");
                jesus++;
            }
            System.Console.WriteLine(jesus);
            
            var randArray = new int[]{1,2,33, 4,5};
            var index = 1;
            foreach (var value in randArray)
            {
                System.Console.WriteLine($"Array element {index}: {value}");
                index += 1;
            }

            // Using doWhile loop
            // Basically, a doWhile loop loops atleast once because the condition exists at the end of the loop
            var doWhile = 0;
            do
            {
                doWhile ++;
                System.Console.WriteLine("This has been looped and current value of doWhile: {0}", doWhile);
            } while (doWhile < 0);

            // using break and continue
            var checkValue = 0;
            while (checkValue < 100)
            {
                checkValue ++;
                if (checkValue > 50)
                {
                    System.Console.WriteLine("Yeah this value reached 50, so I'm breaking it");
                    break;
                }
                else if (checkValue > 49)
                {
                    System.Console.WriteLine("This value is about to reach 50");
                    continue;
                }
            }
            System.Console.WriteLine("checkValue: {0}", checkValue);


            // Listing even numbers from 1-10
            for (var start = 0; start < 11; start += 2)
            {
                System.Console.WriteLine(start);
            }
            var solutions = new Challenges();
            // solutions.Question1();
            // solutions.Question2();
            // solutions.Factorial();
            // solutions.GuessingGame();
            // solutions.findMaximum();

            var password = new Password();
            password.PasswordGenerator();
            System.Console.WriteLine("Random Password Generator: "+ password.SecurePassword());
        }
    }
}

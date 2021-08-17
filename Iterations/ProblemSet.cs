using System;

namespace Iterations
{
    public class Challenges
    {
        public void Question1()
        {
            int count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count ++;
            }
            System.Console.WriteLine("Number of integers divisible by 3: " + count);
        }

        public void Question2()
        {
            const string quit = "ok";
            var sum = 0;
            while (true)
            {
                System.Console.WriteLine("Enter a number or 'ok' to exit");
                string userString = Console.ReadLine();
                if (userString == quit)
                    break;
                sum += Convert.ToInt32(userString);
            }
            System.Console.WriteLine("Sum of all the inputs you entered: "+ sum);
        }

        public void Factorial()
        {
            System.Console.WriteLine("Enter the factorial you want to know the value of: ");
            int factorialValue = Convert.ToInt32(Console.ReadLine());
            var sol = 1;
            do
            {
                sol *= factorialValue;
                factorialValue -= 1; 
            } while (factorialValue > 1);
            System.Console.WriteLine($"Factorial: {sol}");
        }

        public void GuessingGame()
        {
            Random random = new Random();
            int generator = random.Next(1, 11);
            System.Console.WriteLine("Random Number Generator generated: "+ generator);
            int guesses = 0;
            while (guesses < 4)
            {
                System.Console.WriteLine("Take a guess: ");
                int userGuess = Convert.ToInt32(Console.ReadLine());
                guesses ++;
                if (userGuess == generator)
                {
                    System.Console.WriteLine("Yay! You guessed right! The number is "+ userGuess);
                    return;
                }
            }    
            System.Console.WriteLine("You lost! You suck at guessing");
        }
        
        public void findMaximum()
        {
            System.Console.WriteLine("Enter a series of numbers separated by commas: ");
            string user = Console.ReadLine();
            string[] userArray = user.Split(",");
            var localMax =  Convert.ToInt32(userArray[0]);
            foreach (var strNums in userArray)
            {
                if (localMax <= Convert.ToInt32(strNums))
                {
                    localMax = Convert.ToInt32(strNums);
                }
            }
            System.Console.WriteLine("Max value in this list: " + localMax);
        }


    }
}
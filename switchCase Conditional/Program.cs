using System;

namespace switchCase_Conditional
{    
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Rainy;

            switch (season)
            {
                case Season.Autumn:
                    System.Console.WriteLine("It's Autumn and a beautiful season");
                    break;
                case Season.Summer:
                    System.Console.WriteLine("It's perfect time to go to beach");
                    break;
                case Season.Spring:
                case Season.Rainy:
                    System.Console.WriteLine("Yeah these seasons suck dick and I just included 2 seasons to give this message avoiding duplicates");
                    break;
                default:
                    System.Console.WriteLine("I don't understand this season");
                    break;
            }


            System.Console.WriteLine("Input a number between 1 and 10");
            string user = Console.ReadLine();

            // try
            // {
            //     int userInput = Convert.ToInt32(user);

            // }
            // catch (System.Exception)
            // {
            //     System.Console.WriteLine("Invalid");
            // }
            
            int userInput = Convert.ToInt32(user);

            var result = (userInput > 0 && userInput < 10)? "Valid!" : "Invalid"; 
            System.Console.WriteLine(result);


            System.Console.WriteLine("Enter the first number");
            string str1 = Console.ReadLine();
            System.Console.WriteLine("Enter the second number");
            string str2 = Console.ReadLine();

            string max = (Convert.ToInt16(str1) > Convert.ToInt16(str2))? str1 : str2;
            System.Console.WriteLine(max);

            System.Console.WriteLine("Enter Width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            
            string check = (width > height)? "Landscape":"Portrait";
            System.Console.WriteLine(check);


            // ------------ TRAFFIC CAMERA
            System.Console.WriteLine("Enter speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter your car speed: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
            {
                System.Console.WriteLine("OK");
            }
            else
            {
                int demerit = (carSpeed - speedLimit) / 5;
                System.Console.WriteLine(demerit);
                if (demerit > 12)
                    System.Console.WriteLine("License Suspended");
            }
                

        }
    }
}

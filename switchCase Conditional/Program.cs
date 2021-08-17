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
        }
    }
}

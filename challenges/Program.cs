using System;

namespace challenges
{
    public class Conditionals
    {
        public void Question1()
        {
            System.Console.WriteLine("Enter a number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            string check = (userNumber > 0 && userNumber < 10)? "Valid":"Invalid";
            System.Console.WriteLine(check);
        }
    }
    static void Main(string[] args)
    {
    }
}

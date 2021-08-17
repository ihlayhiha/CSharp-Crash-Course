using System;

namespace ifElse_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {    
                Console.WriteLine("It's Morning time!");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's  Afternoon time!");
            }
            else
            {
                Console.WriteLine("It's Evening time!!");    
            } 

            bool isGoldCustomer = true;
            bool isLocal = false;
            // float price;
            // if (isGoldCustomer)
            //     price = 19.92f;
            // else
            //     price = 29.92f;


            float price = (isGoldCustomer) ? 19.92f : 29.92f;

            var askWhere = (isLocal)? "No need to ask someone else" : "Yeah, you probably should ask someone else";

            System.Console.WriteLine(price);
            System.Console.WriteLine(askWhere);
        }
    }
}

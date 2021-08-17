using System;
using System.Collections.Generic;

namespace Arrays
{
    public class Challenges
    {
        public void facebookPattern()
        {
            var list = new List<string>();
            while (true) 
            {
                System.Console.WriteLine("Enter a friend's name: ");
                var name = Console.ReadLine();
                if (name == "")
                    break;
                else
                {
                    list.Add(name);
                }
            }
            var count = list.Count;
            switch (count)
            {
                case (0):
                    break;
                case (1):
                    System.Console.WriteLine($"{list[0]} liked this post");
                    break;
                case (2):
                    System.Console.WriteLine($"{list[0]} and {list[1]} liked this post");
                    break;
                default:
                    System.Console.WriteLine($"{list[0]}, {list[1]} and others liked this post");
                    break;
            }

        }

        public void ReverseName()
        {
            System.Console.WriteLine("Please Enter Your Name: ");
            var name = Console.ReadLine();
            var nameArray = name.ToCharArray();
            Array.Reverse(nameArray);

            // Both methods are fine

            var reversedName = string.Join("", nameArray);
            System.Console.WriteLine(reversedName);

            System.Console.WriteLine(new string(nameArray));

        }

        public void DistinctSort()
        {
            var list = new List<int>();
            var check = 0;
            while (check < 5)
            {
                check++;
                System.Console.WriteLine("Enter any number you haven't entered before: ");
                var item = Convert.ToInt32(Console.ReadLine());
                if (list.Contains(item))
                    continue;
                else
                    list.Add(item);

            }
            list.Sort();
            foreach (var i in list)
                Console.Write(" " +i);
            Console.WriteLine();
        }

        public void UniqueSearch()
        {
            var list = new List<int>();
            var checkList = new List<int>();
            while (true)
            {
                System.Console.WriteLine("Enter any number or ('quit' to exit): ");
                var input = Console.ReadLine();
                if (input == "quit")
                    break;
                else
                {
                    var element = Convert.ToInt32(input);
                    list.Add(element);   
                }
            }
            for (var i = 0; i < list.Count; i++)
            {
                if (list.IndexOf(list[i]) == list.LastIndexOf(list[i]))
                    System.Console.Write(" " + list[i]);
            }
            Console.WriteLine();
        }

        public void CommaList()
        {
            System.Console.WriteLine("Enter a number list separated by commas: ");
            var input = Console.ReadLine();

            var array = input.Split(',');
            var list = new List<string>(array);

            if (list.Count < 5)
                System.Console.WriteLine("Invalid List. Re-try running the program again");
            else
            {
                var localList = new List<int>();
                foreach (var i in list)
                    localList.Add(Convert.ToInt32(i));
                localList.Sort();
                for (var i = 0; i < 3; i++)
                    System.Console.WriteLine(localList[i]);
            }

            // {
            //     var loop = 0;
            //     var localMax = Convert.ToInt32(list[0]);
            //     while (loop < 3)
            //     {
            //         loop ++;
            //         foreach (var number in list)
            //         {
            //             if (localMax < Convert.ToInt32(number))
            //                 localMax = Convert.ToInt32(number);
            //         }
            //         System.Console.Write(" " +localMax);
            //         list.Remove(localMax.ToString());
            //         localMax = Convert.ToInt32(list[0]);
                
            //     }
            // }
            // Console.WriteLine();
            
        }

    }
}
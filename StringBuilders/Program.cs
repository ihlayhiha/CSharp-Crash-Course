using System;
using System.Text;
using System.Collections.Generic;

namespace StringBuilders
{
    class Program
    {
        static void Main(string[] args)
        {
            // strings
            var randString = "A brown fox kills the cat   ";
            // methods on strings create new strings. Does not change the original string
            Console.WriteLine("SubString from 1-10:" + randString.Substring(1, 10));
            Console.WriteLine("Using Trim: '{0}'", randString.Trim());

            // Using StringBuilders
            var builder = new StringBuilder();
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Ravi Teja Yella") 
                .AppendLine()
                .Insert(2, "Inserting this at idx: 2")
                .Remove(10, 2)
                .Replace('-', '*');
            
            Console.WriteLine("This builder is pretty fucked up. Anyway: \n" + builder);

            // Interacting with Console to printout Challenges

            // Problem1
            // Console.WriteLine("Write a few numbers separated by hyphen: ");
            // var line = Console.ReadLine();
            // Console.WriteLine(CheckIfConsecutive(line));
                

            // Problem2
            Console.WriteLine("Enter a list of numbers separated by hyphes: ");
            var line2 = Console.ReadLine();
            Console.WriteLine(CallDuplicates(line2));
        }

        public static string CheckIfConsecutive(string line)
        {
            var inputArray = line.Split('-');
            var  i = Convert.ToInt32(inputArray[0]);
            foreach (var str in inputArray)
            {
                if (i != Convert.ToInt32(str))
                    return "Not Consecutive";
                i++;
            }
            return "Consecutive";
        }

        public static string CallDuplicates(string line2)
        {
            if (String.IsNullOrEmpty(line2))
                return "";
            else
            {
                var inputArray = line2.Split('-');
                var checkList = new List<string>();
                foreach (var str  in inputArray)
                {
                    if (checkList.Contains(str))
                        return "Duplicate";
                    else
                        checkList.Add(str);
                }
                return "";
            }

        }

    }
}

using System;
using System.IO;

namespace Working_with_Files___Directories_and_Paths
{
    public class Challenges
    {
        public static string path = "/home/yella/Documents/csgo.txt"; 
        public static void NumberOfWords()
        {
            var lineArray = File.ReadAllLines(path);
            
            var count = 0;
            foreach(var line in lineArray)   
            {
                var wordsArray = line.Split(" ");
                foreach (var word in wordsArray)
                    count++;
            }
            Console.WriteLine(count);
        }   

        public static void LongestWord()
        {
            var lineArray = File.ReadAllLines(path);
            var str = "";
            foreach (var line in lineArray)
            {
                var wordsArray = line.Split(" ");
                foreach (var word in wordsArray)
                {
                    if (str.Length < word.Length)
                        str = word;
                }
            }
            Console.WriteLine(str);
        }
    }
}
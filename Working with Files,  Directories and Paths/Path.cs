using System;
using System.IO;

namespace Working_with_Files___Directories_and_Paths
{
    public class UsingPathClass
    {
        public static void Printables()
        {
            var path = "/home/yella/Music/Taylor Swift/Taylor Swift - Lover (2019)/Cover.jpeg";

            // If we want to get just the .jpeg value from path

            // Using poor string method
            var dotIndex = path.IndexOf('.');
            var subString = path.Substring(dotIndex);
            Console.WriteLine("Using subString: " +subString);


            // Using better  Path Class. Obviously uses Static method
            var extension = Path.GetExtension(path);
            Console.WriteLine("Path Extension: " + extension);
            Console.WriteLine("Get File Name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));
        }
    }
}
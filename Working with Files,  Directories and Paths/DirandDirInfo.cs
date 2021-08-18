using System;
using System.IO;

namespace Working_with_Files___Directories_and_Paths
{
    public class UsingDirectoryClasses
    {
        public static void Printables()
        {
            var movies = "/home/yella/Videos/movies";
            var csFiles = "/home/yella/Documents/C# Crash Course/";
            {
                // Directory class has static methods
                // DirectoryInfo class has instance methods
            }
            // Using Directory Class
            Directory.CreateDirectory(movies);

            var pathForMovies = Directory.GetFiles(movies +"/Telugu/");
            foreach (var file in pathForMovies)
                Console.WriteLine("Path for Telugu movies: "+ file);

            Console.WriteLine();
            var files = Directory.GetFiles(csFiles, "*.cs", SearchOption.AllDirectories);          
            Console.WriteLine("Printing out All the possible .cs files with their paths in Documents folder");
            foreach (var file in files)
                Console.WriteLine(file);
            
            Console.WriteLine("Printing out the directories from the movies directory in Videos");
            var directories = Directory.GetDirectories(movies);
            foreach (var dir in directories)
                Console.WriteLine(dir);

            if (Directory.Exists(movies))
                Console.WriteLine("Yes, movies directory exists in Videos");

            

            // Using DirecoryInfo
            var dirInfo = new DirectoryInfo(movies);
            var dirArray = dirInfo.GetDirectories();
            var fileArray = dirInfo.GetFiles();

        }
    }
}
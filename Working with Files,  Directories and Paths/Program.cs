using System;
using System.IO;

namespace Working_with_Files___Directories_and_Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Info about File and FileInfo
                // File and FileInfo classes
                // File has all static methods while FileInfo has all instance methods
            }


            // Using File methods, all are static methods, so u have to call them by File.method()

            // var path = "/home/yella/Documents/myCopy.txt";
            // File.Copy("/home/yella/Documents/C# Crash Course/usingFileClass.txt", "/home/yella/Documents/myCopy.txt", true);
            // if (File.Exists(path))
            //     Console.WriteLine("yes this path exists");

            // var content = File.ReadAllText(path);
            // Console.WriteLine(content);
            // Console.WriteLine(File.ReadAllBytes(path));

            // File.Delete(path);
            // File.Delete("/home/yella/Documents/C# Crash Course/usingFileClass.txt");
            // File.Create("/home/yella/Documents/forFileInfo.txt");



            // Using FileInfo methods, all are instance methods, so u can only call them by creating an instance

            // var newPath = "/home/yella/Documents/forFileInfo.txt";
            // var fileInfo = new FileInfo(newPath);
            // fileInfo.CopyTo("/home/yella/Documents/C# Crash Course/destination.txt", true);
            // if (fileInfo.Exists)
            //     Console.WriteLine("Yes, this new file also exists");
            // fileInfo.Delete();

            // var copiedFilePath = "/home/yella/Documents/C# Crash Course/destination.txt";
            // var copiedFileInfo = new FileInfo(copiedFilePath);
            // copiedFileInfo.Delete();

            // FileInfo doesn't have a ReadAll method



            // Using Directory and DirectoryInfo Classes
            UsingDirectoryClasses.Printables();

            

        }
    }
}

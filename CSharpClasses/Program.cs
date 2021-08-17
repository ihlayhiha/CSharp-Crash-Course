using System;
using CSharpClasses.moreClasses;
using CSharpClasses.tryEnum;

namespace CSharpClasses
{
    public class Troll
    {
        public string name;
        public void chant()
        {
            Console.WriteLine($"Me {name}. Me says Yabuk Yabuk Yabuk");
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            var troll = new Troll();
            troll.name = "Hobbit";
            troll.chant();

            var yella = new Person();
            yella.LastName = "Yella";
            yella.FirstName = "Ravi Teja";
            yella.Introduce();

            var sandeep = new Person();
            sandeep.FirstName = "Sandeep";
            sandeep.LastName = "Yella";
            sandeep.Introduce();   

            var calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            var dracula = new Vampire();
            dracula.name = "Count Dracula";
            Console.WriteLine(dracula.chant);
            Console.WriteLine($"{dracula.name}'s current health: {dracula.health}");

            dracula.Damage(5);

            {
                // ARRAYS ------------------
                // initializing an array
                int[] nums1 = new int[3];
                nums1[0] = 1;
                nums1[1] = 2;   // if u don't provide values, they're initialized by '0' by default

                // initializing an array another way
                int[] nums2 = new int[3]{1, 2, 3};

                // initializing an array another way
                var numbers = new int[5]{1, 2, 3, 4, 5};

                var checkNums = new int[5];
                checkNums[0] = 1000; 
                checkNums[4] = 1001;
                Console.WriteLine(checkNums[0]);
                Console.WriteLine(checkNums[1]);
                Console.WriteLine(checkNums[2]);
                Console.WriteLine(checkNums[3]);
                Console.WriteLine(checkNums[4]);

                // When u initialize an array, all the values are initialized to the default values of the data type assigned to that array
                // Default values for int = 0
                // Default values for boolean arrays = False

                var sendTruth = new bool[3];
                sendTruth[0] = true;

                var names = new string[3]{"Ravi", "Teja", "Yella"};

                Console.WriteLine(sendTruth[0]);
                Console.WriteLine(sendTruth[1]);
                Console.WriteLine(sendTruth[2]);

                Console.WriteLine(nums1);
                Console.WriteLine(nums2);
            }

            {
                // STRINGS -------------
                // Using String Literal
                var randString = "This is a random string";
                Console.WriteLine(randString[0]);

                // Concatenating string
                var myName = yella.FirstName + " " + yella.LastName;

                // another way of concatenating
                string myBroName = string.Format("{0} {1}", sandeep.FirstName, sandeep.LastName);
                var newName = $"My brother's name is {sandeep.FirstName} {sandeep.LastName}";


                // Using string.Format() or string.Join() static methods 
                string broName = string.Format($"{sandeep.FirstName} {sandeep.LastName}");

                var randArray = new int[5]{1, 2, 3, 4, 5};
                string arraytoString = string.Join(", ", randArray);

                Console.WriteLine(arraytoString);

                Console.WriteLine(myName);
                Console.WriteLine(myBroName);
                Console.WriteLine(broName);
                Console.WriteLine(newName);

                // Using Verbatim format for paths written as strings
                var text = "Hello Yella!\nYou might wanna check this folder with path:" +
                            "\nWindows Path: c:\\usr\\documents\\C# Crash Course\\CsharpClasses" +
                            "\nLinux Path: ~/Documents/C# Crash Course/CsharpClasses";
                Console.WriteLine(text);
                Console.WriteLine();
                
                //Using verbatim for strings. Basically converts to a literal representation of string in the code. i.e if u use indentation, string  printed out as TABBED
                var alternateText =  @"Hello Yella!
You might wanna check this folder with path:
Windows Path: c:\user\documents\C# Crash Course\CSharpClasses
Linux Path: ~/Documents/C# Crash Course/CSharpClasses";
                Console.WriteLine(alternateText);

                // Using the String class to declare strings is also the same
                var randPerson = new Person();
                randPerson.FirstName = "Random";
                randPerson.LastName = "Person";

                String sayHello = $"Hello! {randPerson.FirstName} {randPerson.LastName}";
                Console.WriteLine(sayHello);

                var names = new string[3]{"WHAT", "THE", "FUCK"}; 
                string randFormat = string.Format("What does this do????");
                String formattedNames = string.Join(", ", names);

                Console.WriteLine(formattedNames);
                Console.WriteLine(randFormat);

            }

            Int16 int16 = 16;
            Int32 checkInt32 = 32;  // the same thing as declaring by using int
            int checkInt = 32;
            Console.WriteLine(checkInt32);
            Console.WriteLine(checkInt);
            Console.WriteLine(int16);

            {
                // TRYING  ENUM ---------------
                var method = ShippingMethod.Express;
                Console.WriteLine(method);
                Console.WriteLine(method.GetType());
                Console.WriteLine((int)method); //Casting the 'method' to an integer as it holds an integer value

                // Casting an integer into a ShippingMethod
                var methodId = 3;
                Console.WriteLine((ShippingMethod)methodId);

                // Every object in CSharp has a method called ToString
                string methodString = method.ToString();
                Console.WriteLine(methodString);

                // Parsing = getting a string and converting it into a different datatype
                // Every class has a .Parse() method included in our System
                // Parse  class asks for the type u want as output first, and then the string which you want the method to convert
                // It returns an object. and then the object has to be casted into whatever datatype u want
                var methodName = "Express";
                // Enum.Parse(typeof(ShippingMethod), methodName);  will convert methodName string into some object
                var methodShippingType = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
                Console.WriteLine(methodShippingType);
                Console.WriteLine(methodShippingType.GetType());

            }
            var checkArray = new int[10];
            Console.WriteLine(checkArray.GetType());
        }
    }
}

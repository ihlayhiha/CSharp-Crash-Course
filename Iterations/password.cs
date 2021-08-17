using System;

namespace Iterations
{
    public class Password
    {
        public void PasswordGenerator()
        {
            var random = new Random();
            System.Console.Write("Random Password Generator: ");
            for (var i = 0; i < 10; i++)
                System.Console.Write((char)(random.Next((int)'a', (int)'z')));

            System.Console.WriteLine();
        }
        public string SecurePassword()
        {
            const int length = 10;
            var buffer = new char[length];
            var passRandom = new Random();

            for (var i = 0; i < length; i ++)
                buffer[i] = (char)passRandom.Next((int)'a', (int)'z'+ 1);

            string password = string.Join("", buffer);
            System.Console.WriteLine("Another way of creating a string from char array: "+ password);
            return new string(buffer);
        }
        
    }
}

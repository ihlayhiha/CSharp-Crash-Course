using System;

namespace DateTime_type
{
    class Program
    {
        static void Main(string[] args)
        {
            var randDateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            System.Console.WriteLine(now);

            var nowHour = now.Hour;
            var nowMinute = now.Minute;
            
            System.Console.WriteLine($"Hour: {nowHour} Minute: {nowMinute}");

            var today = DateTime.Today;
            System.Console.WriteLine(today);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            System.Console.WriteLine($"Yesterday: {yesterday}, Tomorrow: {tomorrow}");


            System.Console.WriteLine("Coverting datetime to a string");
            System.Console.WriteLine();
            // Coverting DateTime object to a string
            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.ToShortDateString());
            System.Console.WriteLine(now.ToLongTimeString());
            System.Console.WriteLine(now.ToShortTimeString());
            System.Console.WriteLine(now.ToString());

            // .ToString() method can take an argument where we can specify the format
            System.Console.WriteLine(now.ToString("yyyy-MM-dd"));
            System.Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ffff"));


            // Timespan c
            var useTimeSpan = new UsingTimeSpan();
            useTimeSpan.Printable();
        }
    }
}

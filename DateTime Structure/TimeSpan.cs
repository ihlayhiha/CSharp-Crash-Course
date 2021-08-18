using System;

namespace DateTime_type
{
    public class UsingTimeSpan
    {
        public void Printable()
        {
            // creating TimeSpan
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(100);

            // Subtracting DateTimes gives u a TimeSpan
            var timeSpan3  = end - start;

            System.Console.WriteLine(timeSpan);
            System.Console.WriteLine(timeSpan1);
            System.Console.WriteLine(timeSpan2);
            System.Console.WriteLine("Duration between start and end: " + timeSpan3);

            // Properties
            System.Console.WriteLine("timeSpan Mintues: " + timeSpan.Minutes);
            System.Console.WriteLine("timeSpan Total Mintues: " + timeSpan.TotalMinutes);

            // .Add()
            var newSpan = timeSpan.Add(timeSpan2);
            System.Console.WriteLine("newSpan which is timeSpan + timeSpan2");
            Console.WriteLine("A new timeSpan created and added in the method itself: " + timeSpan.Add(new TimeSpan(1, 0, 0)));
            Console.WriteLine("A new timeSpan created and added in the method itself: " + timeSpan.Add(TimeSpan.FromHours(1)));

            // .Subtract() 
            Console.WriteLine("timeSpan1 : " + timeSpan1);
            Console.WriteLine("Subtracting 1 hour from timeSpan1: " + timeSpan1.Subtract(TimeSpan.FromHours(1)));

            // .ToString() 
            Console.WriteLine("To String: " + timeSpan.ToString());

            // TimeSpan.Parse()
            // Parse always means takes a string and converts it to another type
            Console.WriteLine("Parse Method: " + TimeSpan.Parse("01:02:03"));
            Console.WriteLine("Using .GetType() to check: " + TimeSpan.Parse("01:02:03").GetType());
        }
    }
}
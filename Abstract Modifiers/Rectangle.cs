using System;

namespace Abstract_Modifiers
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a rectangle");
        }
    }
}
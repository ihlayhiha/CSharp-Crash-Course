using System;

namespace Access_Modifiers.MethodOverride
{
    public class Rectangle :  Shape
    {
        public override void Draw()
        {
            base.Draw();
            System.Console.WriteLine("Drawing a rectangle");
        }
    }
}
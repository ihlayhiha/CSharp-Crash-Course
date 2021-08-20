using System;

namespace Access_Modifiers.MethodOverride
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            System.Console.WriteLine("Drawing a triangle");
        }
    }
}
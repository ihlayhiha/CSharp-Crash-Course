using System;

namespace Access_Modifiers.MethodOverride
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            System.Console.WriteLine("Drawing a circle");
        }
    }
}

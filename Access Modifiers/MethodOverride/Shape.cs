using System;

namespace Access_Modifiers.MethodOverride
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        public virtual void Draw()
        {
            System.Console.WriteLine("Understanding and initializing the Shape");
        }

    }
}
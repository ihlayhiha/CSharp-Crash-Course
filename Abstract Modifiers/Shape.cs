using System;

namespace Abstract_Modifiers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();
        // If there's an abstract method, the class have to be abstract as well
        // The method cannot have an implementation i.e a body. It should just be defined that's all

        public void Copy()
        {
            System.Console.WriteLine("{0} copied to the clipboard", this.GetType());
        }

        public void Select()
        {
            System.Console.WriteLine("Selected the shape");
        }
    }
}

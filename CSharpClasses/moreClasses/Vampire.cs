using System;

namespace CSharpClasses.moreClasses
{
    public class Vampire
    {
        public int health=10;
        public string name;
        public string chant = "I'm gonna suck the blood out of your ass!";
        public void Damage(int hits)
        {
            health -= hits;
            Console.WriteLine($"\n'{name}': Ahhhhhhhh, u hit me! You rat bastard!!\n");
            Console.WriteLine($"The Vampire has been hit for {hits} points.\nCurrent health of the vampire: {health}");   
        }
    }
}
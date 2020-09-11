using System;
using System.Collections.Generic;
using System.Text;

namespace StoryTime
{
    class Program2
    {
        internal static void AnimalStory()
        {
            Animal a1 = new Animal();
            a1.Kind = "Sköldpadda";
            a1.Name = "Aron";
            a1.IsFast = false;
            a1.NumberOfLegs = 4;

            Console.WriteLine(Animal.BuildStory(a1));

            Animal a2 = new Animal();
            a2.Kind = "Jaguar";
            a2.Name = "Tina";
            a2.IsFast = true;
            a2.NumberOfLegs = 4;

            Console.WriteLine(Animal.BuildStory(a2));

            Animal a3 = new Animal();
            a3.Kind = "";
            a3.Name = "";
            a3.IsFast =;
            a3.NumberOfLegs =;
        }
    }
}

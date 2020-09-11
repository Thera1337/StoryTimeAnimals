using System;
using System.Collections.Generic;
using System.Text;

namespace StoryTime
{
    class Animal
    {
        public string Kind { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsFast { get; set; }
        public int Age { get; set; }


        public static int CalculateAge(int birthYear)
        {
            int year = DateTime.Now.Year;
            return year - birthYear;
        }

        public static string BuildStory(Animal a)
        {
            string story = $"Det var en gång en {a.Age} år gammal {a.Kind} som hette {a.Name}.\n" +
                $"En dag var {a.Name} ute på promenad i skogen, och mötte en stor varg.\n" +
                $"Vargen bet av ett ben.";

            if (a.IsFast)
            {
                story += $"{a.Name} sprang snabbt hem på sina {a.NumberOfLegs - 1}.\n";
            }
            else
            {
                story += $"{a.Name} sprang långsamt hem på sina {a.NumberOfLegs - 1}. \n";
            }

            story += "Så var sagan slut!";

            return story;
        }
    }
}

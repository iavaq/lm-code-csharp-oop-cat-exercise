using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise.Models
{
    public class DomesticCat : Cat
    {
        public DomesticCat() : base(23, "domestic")
        {
        }

        public override string Eat()
        {
            Random randomize = new Random();

            if (randomize.Next(2).Equals(1))
            {
                Console.WriteLine("It will do I suppose");
            }
    
            return "Purrrrrrr";
        }
    }
}

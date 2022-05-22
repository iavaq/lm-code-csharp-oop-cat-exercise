using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise.Models
{
    public class LionCat : Cat
    {
        public LionCat() : base(1100, "wild")
        {
        }

        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
}

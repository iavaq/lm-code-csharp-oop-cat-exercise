using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise.Models
{
    public class CheetahCat : Cat
    {
        public CheetahCat() : base(1000, "wild")
        {
        }

        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}

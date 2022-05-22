using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise.Models
{
    public class DomesticCat : Cat
    {
        public DomesticCat() : base()
        {
            AverageHeight = 23;
            Setting = "domestic";
        }

        public override string Eat()
        {
            return "Purrrrrrr";
        }
    }
}

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
            return "Purrrrrrr";
        }
    }
}

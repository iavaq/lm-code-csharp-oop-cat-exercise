using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise.Models
{
    public class LionCat : Cat
    {
        public LionCat() : base()
        {
            AverageHeight = 1100;
            //Setting = CatEnums.Setting.wild;
        }

        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
}

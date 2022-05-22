using System;
using System.Collections.Generic;
using System.Text;

namespace OopCatExercise.Models
{
    public class CheetahCat : Cat
    {
        public CheetahCat() : base()
        {
            //AvergeHeight = ;
            //Setting = CatEnums.Setting.wild;
        }

        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}

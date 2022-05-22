using System;
namespace OopCatExercise.Models
{
    public abstract class Cat : ICat
    {
        public bool IsAsleep { get; private set; }
        public double AverageHeight { get; set; }
        public string Setting { get; set; }

        public abstract string Eat();

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public virtual void WakeUp()
        {
            IsAsleep = false;
        }
    }

}

using System;
namespace OopCatExercise.Models
{
    public abstract class Cat : ICat
    {
        public bool IsAsleep { get; private set; } = false;
        public double AverageHeight { get; private set; }
        public string Setting { get; private set; }

        public Cat(double height, string setting)
        {
            AverageHeight = height;
            Setting = setting;
        }

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

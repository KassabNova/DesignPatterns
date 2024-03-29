using System;

namespace ChainOfCommandBeverages
{
    //This is the abstract class
    public abstract class BeverageWithHook
    {
        public void prepareRecipe(bool wantsCondiments)
        {
            boilWater();
            brew();
            powerInCup();

            if (wantsCondiments)
            {
                addCondiments();
            }
        }
        public abstract void brew();
        public abstract void addCondiments();
        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }
        public void powerInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        // this is a hook because the subclass can override this method, but doesn't have to
        public bool customerWantsCondiments()
        {
            return true;
        }
    }
}
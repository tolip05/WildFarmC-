using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Mammals
{
    public class Cat : Feline
    {
        private const double increaseWeight = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void EatFood(Food food)
        {
            if (!food.GetType().Name.Equals("Vegetable") && !food.GetType().Name.Equals("Meat"))
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            else
            {
                base.FoodEaten += food.Quantity;
                base.Weight += food.Quantity * increaseWeight;
            }
        }

        public override void ProduseSound()
        {
            Console.WriteLine("Meow");
        }
    }
}

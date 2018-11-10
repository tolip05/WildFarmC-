using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Mammals
{
    public class Dog : Mammal
    {
        private const double increaseWeight = 0.40;

        public Dog(string name, double weight, string LivingRegion) 
            : base(name, weight, LivingRegion)
        {
        }

        public override void EatFood(Food food)
        {
            if (!food.GetType().Name.Equals("Meat"))
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
            Console.WriteLine("Woof!");
        }
    }
}

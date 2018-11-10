using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Mammals
{
    public class Mouse : Mammal
    {
        private const double increaseWeight = 0.10;

        public Mouse(string name, double weight, string LivingRegion) 
            : base(name, weight, LivingRegion)
        {
        }

        public override void EatFood(Food food)
        {
            if (!food.GetType().Name.Equals("Vegetable") && !food.GetType().Name.Equals("Fruit"))
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
            Console.WriteLine("Squeak");
        }
    }
}

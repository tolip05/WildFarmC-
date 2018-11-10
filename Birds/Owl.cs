using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Birds
{
    public class Owl : Bird
    {
        private const double increaseWeight = 0.25;

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
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
            Console.WriteLine("Hoot Hoot");
        }
    }
}

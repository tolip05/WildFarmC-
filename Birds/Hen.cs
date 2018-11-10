using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Birds
{
    public class Hen : Bird
    {
        private const double increaseWeight = 0.35;

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void EatFood(Food food)
        {
            
                base.FoodEaten += food.Quantity;
                base.Weight += food.Quantity * increaseWeight;
            
        }

        public override void ProduseSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}

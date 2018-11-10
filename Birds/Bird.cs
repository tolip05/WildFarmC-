using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals;

namespace WildFarm.Birds
{
    public abstract class Bird : Animal
    {
        private double wingSize;
        protected Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get => wingSize; set => wingSize = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }

}

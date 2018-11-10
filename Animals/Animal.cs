using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Foods;

namespace WildFarm.Animals
{
   public abstract class Animal : IAnimal
    {
        private string name;

        private double weight;

        private int foodEaten;

        protected Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = 0;
        }

        public string Name { get => name; set => name = value; }
        public virtual double Weight
        {
            get => weight;
            set
            {
                weight = value;
            }
        }
        public virtual int FoodEaten
        {
            get => foodEaten;
            set
            {
                foodEaten = value;
            }
        }

        public abstract void ProduseSound();
        public abstract void EatFood(Food food);
    }
}

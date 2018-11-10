﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals;

namespace WildFarm.Mammals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;
        protected Mammal(string name, double weight,string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get => livingRegion; set => livingRegion = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}

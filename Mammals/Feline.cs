﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Mammals
{
    public abstract class Feline : Mammal
    {
       private string breed;

        protected Feline(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get => breed; set => breed = value; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}

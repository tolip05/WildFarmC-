﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Factory
{
   public class FoodFactory
    {
        public Food CreateFood(string type,int quantity)
        {
            type = type.ToLower();
            switch (type)
            {
                case "fruit":
                    return new Fruit(quantity);
                case "meat":
                    return new Meat(quantity);
                case "seeds":
                    return new Seeds(quantity);
                case "vegetable":
                    return new Vegetable(quantity);

                default:
                    throw new ArgumentException("Invalid food type!");
            }
        }
    }
}

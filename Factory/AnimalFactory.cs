using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals;
using WildFarm.Birds;
using WildFarm.Mammals;

namespace WildFarm.Factory
{
   public class AnimalFactory
    {
        public Animal CreateAnimal(string[] tokens)
        {
            string type = tokens[0];
            type = type.ToLower();

            string name = tokens[1];

            double weight = double.Parse(tokens[2]);

            switch (type)
            {
                case "cat":
                    
                    return new Cat(name,weight,tokens[3],tokens[4]);
                case "tiger":
                    return new Tiger(name, weight, tokens[3], tokens[4]);

                case "dog":
                    return new Dog(name, weight,tokens[3]);
                case "mouse":
                    return new Mouse(name, weight, tokens[3]);
                case "hen":
                    return new Hen(name,weight,double.Parse(tokens[3]));
                case "owl":
                    return new Owl(name, weight, double.Parse(tokens[3]));
                default:
                    return null;
            }
        }
    }
}

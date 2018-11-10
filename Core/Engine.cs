using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animals;
using WildFarm.Factory;
using WildFarm.Foods;

namespace WildFarm.Core
{
   public class Engine
    {
        private AnimalFactory animalFactory;
        private FoodFactory foodFactory;
        private HashSet<Animal> animals;

        public Engine()
        {
            this.animalFactory = new AnimalFactory();
            this.foodFactory = new FoodFactory();
            this.animals = new HashSet<Animal>();
        }
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    string[] animalTokens = input
                        .Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    string[] foodTokens = Console.ReadLine()
                        .Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    Food food = this.foodFactory.CreateFood(foodTokens[0],int.Parse(foodTokens[1]));
                    Animal animal = this.animalFactory.CreateAnimal(animalTokens);
                    animal.ProduseSound();
                    animals.Add(animal);
                    animal.EatFood(food);
                    animals.Add(animal);

                   
                }
                catch (ArgumentException e)
                {
                    
                    Console.WriteLine(e.Message);
                }

                
                input = Console.ReadLine();
            }
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}

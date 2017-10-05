using System;
using System.Collections.Generic;

namespace Garden_Application
{
    class Garden
    {
        List<Plant> plants = new List<Plant>();

        public void Add(Plant plant)
        {
            plants.Add(plant);
        }

        public int ThirstyCounter()
        {
            int thirstyPlants = 0;
            foreach (Plant plant in plants)
            {
                if (plant.IsItThirsty())
                {
                    thirstyPlants++;
                }
            }
            return thirstyPlants;
        }

        public void WaterAdding(int wateringNumber)
        {
            Console.WriteLine("Watering with {0}", wateringNumber);
            double onePortion = wateringNumber / ThirstyCounter();
            foreach(Plant plant in plants)
            {
                if (plant.IsItThirsty())
                {
                    plant.waterAmmount+= onePortion * plant.absorbing;
                }
            }
        }

        public void GetStatus()
        {
            foreach (Plant plant in plants)
            {
                if (plant.IsItThirsty())
                {
                    Console.WriteLine("The {0} {1} needs water ", plant.color, plant.plantType);
                }
                else
                {
                    Console.WriteLine("The {0} {1} doesn't need water ", plant.color, plant.plantType);
                }
            }
        }
    }
}

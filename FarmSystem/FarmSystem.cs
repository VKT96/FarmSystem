using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    public class FarmSystem
    {
        Queue<IAnimal> animals = new Queue<IAnimal>();


        //TEST 1
        public void Enter(IAnimal animal)
        {
            animals.Enqueue(animal);
            Console.WriteLine(string.Format("{0} has entered the farm", animal.GetType().Name));
        }

        //TEST 2
        public void MakeNoise()
        {
            foreach (IAnimal animal in animals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            bool milkableAnimalFlag = false;
            foreach (IAnimal animal in animals)
            {
                if (animal is IMilkableAnimal)
                {
                    ((IMilkableAnimal)animal).ProduceMilk();
                    milkableAnimalFlag = true;
                }
            }

            if (!milkableAnimalFlag)
                Console.WriteLine("Cannot identify the farm animals which can be milked");
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            IAnimal animalReleased;
            while (animals.Count != 0)
            {
                animalReleased = animals.Dequeue();
                Console.WriteLine(string.Format("{0} has left the farm", animalReleased.GetType().Name));
            }

            if (animals.Count == 0)
                Console.WriteLine("Farm is now empty");
            else
                Console.WriteLine("There are still animals in the farm, farm is not free");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    /// <summary>
    /// Class to include static method that can help to create a new animal.
    /// </summary>
    public class AnimalFactory
    {
        public static IAnimal CreateAnimal(AnimalType animalType)
        {
            IAnimal animal;
            switch (animalType)
            {
                case AnimalType.Cow:
                    animal = new Cow();
                    break;
                case AnimalType.Hen:
                    animal = new Hen();
                    break;
                case AnimalType.Horse:
                    animal = new Horse();
                    break;
                case AnimalType.Sheep:
                    animal = new Sheep();
                    break;
                default:
                    animal = null;
                    break;
            }
            return animal;
        }
    }
}

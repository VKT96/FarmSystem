using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    public class Cow : IAnimal, IMilkableAnimal
    {

        public string Id { get; set; }
        public int NoOfLegs { get; set; }
        public Cow()
        {
            Id = Guid.NewGuid().ToString();
            NoOfLegs = 4;
        }

        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

        public void Run()
        {
            Console.WriteLine("Cow is running");
        }

    }
}
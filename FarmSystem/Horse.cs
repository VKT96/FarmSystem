using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    public class Horse : IAnimal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; set; }
        public Horse()
        {
            Id = Guid.NewGuid().ToString();
            NoOfLegs = 4;
        }


        public void Talk()
        {
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    public class Sheep : IAnimal
    {

        public string Id { get; set; }
        public int NoOfLegs { get; set; }
        public Sheep()
        {
            Id = Guid.NewGuid().ToString();
            NoOfLegs = 4;
        }


        public void Talk()
        {
            Console.WriteLine("Sheep says baa!");
        }

        public void Run()
        {
            Console.WriteLine("Sheep is running");
        }
    }
}
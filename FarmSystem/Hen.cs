using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmSystem
{
    public class Hen : IAnimal
    {
        public string Id { get; set; }
        public int NoOfLegs { get; set; }
        public Hen()
        {
            Id = Guid.NewGuid().ToString();
            NoOfLegs = 2;
        }

        public void Talk()
        {
            Console.WriteLine("Hen say CLUCKAAAAAWWWWK!");
        }

        public void Run()
        {
            Console.WriteLine("Hen is running");
        }
    }
}
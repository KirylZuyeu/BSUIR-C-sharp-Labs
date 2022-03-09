using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Wolf : Dog
    {
        public string FlockName { get; set; }
        public Wolf(string name, string habitat, int weight, int height, int legs, string flockName)
                    : base(name, habitat, weight, height, legs)
        {
            FlockName = flockName;
        }

        public new void Print()
        {
            Console.WriteLine($"I am {Name}, with Flock Name {FlockName} that dwell in {Habitat}.");
        }
    }
}

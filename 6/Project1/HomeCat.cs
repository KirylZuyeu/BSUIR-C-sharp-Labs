using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class HomeCat : Cat
    {
        public string PetName { get; set; }
        public HomeCat(string name, string habitat, int weight, int height, int legs, string petName)
                    : base(name, habitat, weight, height, legs)
        {
            PetName = petName;
        }

        public new void Print()
        {
            Console.WriteLine($"I am {Name}, with Pet Name {PetName} that dwell in {Habitat}.");
        }
    }
}

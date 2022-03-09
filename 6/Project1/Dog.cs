using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Dog : Animal
    {
        public new string Fins
        {
            get => $"Dog Haven't fins";
        }
        public Dog(string name, string habitat, int weight, int height, int legs)
        {
            Name = name;
            Habitat = habitat;
            Weight = weight;
            Height = height;
            Legs = legs;
        }

        public override void GetLimbs()
        {
            Console.WriteLine($"The number of legs is {Legs}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Cat : Animal 
    {
        public new string Fins
        {
            get => $"Cat Haven't fins";
        }
        public Cat(string name, string habitat, int weight, int height, int legs)
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

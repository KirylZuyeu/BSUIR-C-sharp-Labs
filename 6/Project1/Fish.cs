using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Fish : Animal
    {
        public new string Legs
        {
            get => $"Bird Haven't legs";
        }
        public Fish(string name, string habitat, int weight, int height, int fins)
        {
            Name = name;
            Habitat = habitat;
            Weight = weight;
            Height = height;
            Fins = fins;
        }

        public override void GetLimbs()
        {
            Console.WriteLine($"The number of fins is {Fins}");
        }

        public override void Move()
        {
            Console.WriteLine($"I am a {Name} that can swim by {Fins} fins.");
        }

        public new void Print()
        {
            Console.WriteLine($"I am {Name} and my habitat is {Habitat}.");
        }
    }
}

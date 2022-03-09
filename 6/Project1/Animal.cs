using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Habitat { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Legs { get; set; }
        public int Fins { get; set; }

        public abstract void GetLimbs();

        public virtual void Move() {
            Console.WriteLine($"I am a {Name} that can walk on the {Legs} legs.");
        }

        public void Print()
        {
            Console.WriteLine($"I am {Name}, that dwell in {Habitat}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Shark : Fish
    {
        public string CallName { get; set; }
        public Shark(string name, string habitat, int weight, int height, int fins, string callName)
                    : base(name, habitat, weight, height, fins)
        {
            CallName = callName;
        }

        public new void Print()
        {
            Console.WriteLine($"I am {Name}, called as {CallName} of {Habitat}.");
        }
    }
}

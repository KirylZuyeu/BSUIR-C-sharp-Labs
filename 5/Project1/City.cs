using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class City
    {
        public string NameCity { get; }

        public Sight[] sights;

        public City()
        {
        }
        public City(string nameCity)
        {
            NameCity = nameCity;
            sights = null;
        }

        public override string ToString()
        {
            return $"The name of city is {NameCity}.";
        }

        public void PrintSightsOfCity()
        {
            WriteLine($"In the {NameCity} there are next List of sights:");
            for (int i = 0; i < sights.Length; i++)
            {
                WriteLine($"{i + 1}. {sights[i].NameSight} - {sights[i].LocationSight}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class Excursion
    {

        public string NameExcursion { get; }
        public City City;

        public Tourist[] Tourists;
        public Guide Guide;

        public Excursion() : this("None", "None", null, null)
        {
        }

        public Excursion(string nameExcursion, string nameCity) : this(nameExcursion, nameCity, null, null)
        {
        }

        public Excursion(string nameExcursion, string nameCity, Tourist[] tourists, Guide guide)
        {
            NameExcursion = nameExcursion;
            City = new City(nameCity);
            Tourists = tourists;
            Guide = guide;
        }

        public override string ToString()
        {
            return $"The Excursion {NameExcursion} in {City.NameCity}.";
        }

        public void showInfoOfGuide()
        {
            WriteLine($"{Guide.ToString()}");
        }

        public void showListOfTourists()
        {
            WriteLine($"In the {NameExcursion} there are next List of tourists:");
            for (int i = 0; i < Tourists.Length; i++)
            {
                WriteLine($"{Tourists[i].ToString()}");
            }
        }

        public void showListOfSights()
        {
            City.PrintSightsOfCity();
        }

        public void changeGuide(string nameOfGuide, string languageOfGuide)
        {
            Guide = new Guide($"{nameOfGuide}", $"{languageOfGuide}");
            WriteLine($"Guide was changed");
        }

        public void addSightForVisiting(Sight newSeight)
        {
            Array.Resize(ref City.sights, City.sights.Length + 1);
            City.sights[City.sights.Length - 1] = newSeight;
            WriteLine($"Array of Sights was changed.");
        }
    }
}

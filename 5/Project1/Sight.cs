using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class Sight
    {
        public string NameSight { get; }
        public string LocationSight { get; }

        public Sight(string nameSight, string locationSight)
        {
            NameSight = nameSight;
            LocationSight = locationSight;
        }

        public override string ToString()
        {
            return $"Sight {NameSight} that located on {LocationSight}.";
        }
    }
}

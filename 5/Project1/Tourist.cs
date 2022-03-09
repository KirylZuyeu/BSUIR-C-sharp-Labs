using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class Tourist
    {
        public string NameTourist { get; }
        public string Nationality { get; }

        public Tourist(string nameTourist, string nationality)
        {
            NameTourist = nameTourist;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"Tourist {NameTourist} - {Nationality} nationality.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project1
{
    class Guide
    {
        public string NameGuide { get; }
        private string languageGuide;

        public string LanguageGuide
        {
            get
            {
                return languageGuide;
            }
            set
            {
                languageGuide = value;
            }
        }

        public Guide(string nameGuide, string languageGuide)
        {
            NameGuide = nameGuide;
            LanguageGuide = languageGuide;
        }

        public override string ToString()
        {
            return $"Guide {NameGuide} that speak on {LanguageGuide} language.";
        }
    }
}

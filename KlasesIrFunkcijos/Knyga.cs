using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesIrFunkcijos
{
    public class Knyga
    {
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public int PuslapiuSkaicius { get; set; }
        public bool ArPerskaityta { get; set; } = false;

        public Knyga(string pavadinimas, string autorius, int puslapiuSkaicius, bool arPerskaityta)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            PuslapiuSkaicius = puslapiuSkaicius;
            ArPerskaityta = arPerskaityta;
        }
        public Knyga(string pavadinimas, string autorius, int puslapiuSkaicius)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            PuslapiuSkaicius = puslapiuSkaicius;
        }
        public Knyga()
        {
        }

        public bool perskaitytiKnyga()
        {
            Console.WriteLine("ar perskaitete knyga? (taip/ne)");
            if( Console.ReadLine() == "taip")
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void gautiAprasyma()
        {
            Console.WriteLine($"{Pavadinimas}, {Autorius}, {PuslapiuSkaicius}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesIrFunkcijos
{
    /*
     9. Klasė "Studentas"
    Sukurkite klasę Studentas, kurioje būtų:
    Laukai: vardas, pavarde, amzius, ir vidurkis.
    Funkcija pridetiPazymi(double pazymys), kuri atnaujina studento vidurkį pridedant naują pažymį.
    Funkcija arPerejoISekanciaKlase(), kuri grąžina true, jei vidurkis yra 5 ar daugiau, ir false kitu atveju.
    Papildoma praktika: Parašykite Studentas konstruktorių, kuris nustato pradinį vardą, pavardę ir amžių.
     */
    public class Studentas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int Amzius { get; set; }
        public double Vidurkis { get; set; } = 0;

        public Studentas()
        {
        }
        
        public Studentas(string vardas, string pavarde, int amzius)
        {
            vardas = Vardas;
            pavarde = Pavarde;
            amzius = Amzius;
        }
        public Studentas (string vardas, string pavarde, int amzius, double vidurkis)
        {
            vardas = Vardas;
            pavarde = Pavarde;
            amzius = Amzius;
            vidurkis = Vidurkis;
        }
        // vidurkio skaiciavimas ne tas
        public void PridetiPazymi(double pazymys)
        {
            Console.WriteLine($"Studento vidurkis yra ${Vidurkis}");
            Vidurkis += pazymys / 2;
            Console.WriteLine($"Jus pridejote {pazymys} pazymi, dabartinis vidurkis yra {Vidurkis}");
        }

        public bool ArPerejoISekanciaKlase()
        {
            if (Vidurkis >= 5)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}

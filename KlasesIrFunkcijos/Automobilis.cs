using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesIrFunkcijos {
    public class Automobilis
    {
        /* 8. Klasė "Automobilis"
            Sukurkite klasę Automobilis, kurioje būtų:
            Laukai: marke, modelis, metai, ir kuroLikutis (litrais).
            Funkcija pildytiKura(double kiekis), kuri prideda nurodytą kiekį kuro prie kuroLikutis.
            Funkcija vaziuoti(double atstumas), kuri sumažina kuro likutį pagal važiuotą atstumą (laikykite, kad automobilis sunaudoja 1 litrą kuro 10 km).
            Papildoma praktika: Parašykite Automobilis konstruktorių, kuris nustato pradinę markę, modelį ir metus.
        */
            public string Marke { get; set; }
            public string Modelis { get; set; }
            public int Metai { get; set; }
            public double KuroLikutis { get; set; } = 0;


            public Automobilis()
            {
            }

            public Automobilis(string marke, string modelis, int metai)
            {
                Marke = marke;
                Modelis = modelis;
                Metai = metai;
            }
            public Automobilis(string marke, string modelis, int metai, double kuroLikutis)
            {
                Marke = marke;
                Modelis = modelis;
                Metai = metai;
                KuroLikutis = kuroLikutis;
            }

            public void PildytiKura(double kiekis)
            {
                Console.WriteLine($"Jusu bake yra {KuroLikutis}, jus isipilate {kiekis} litru kuro.");
                KuroLikutis += kiekis;
                Console.WriteLine($"Jusu bake yra {KuroLikutis} l");
            }
            public void Vaziuoti(double atstumas)
            {
                Console.WriteLine($"Jus nuvaziavote {atstumas} km");
                KuroLikutis -= atstumas / 10;
                Console.WriteLine($"Jusu bake siuo metu yra {KuroLikutis} l");
            }
        }
}



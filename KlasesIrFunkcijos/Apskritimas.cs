using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesIrFunkcijos
{
    /*
    10. Klasė "Apskritimas"
    Sukurkite klasę Apskritimas, kurioje būtų:
    Laukas spindulys.
    Funkcija skaiciuotiPlota(), kuri grąžina apskritimo plotą (naudokite formulę π⋅spindulys2\pi \cdot spindulys^2π⋅spindulys2).
    Funkcija skaiciuotiPerimetra(), kuri grąžina apskritimo perimetrą (naudokite formulę 2⋅π⋅spindulys2 \cdot \pi \cdot spindulys2⋅π⋅spindulys).
    Papildoma praktika: Pridėkite konstruktorų, leidžiančių sukurti Apskritimas objektą su nurodytu spinduliu.
     */
    public class Apskritimas
    {
        public double Laukas { get; set; } = 0;
        public double Spindulys { get; set; }

        public Apskritimas()
        {
        }

        public Apskritimas(double spindulys)
        {
            spindulys = Spindulys;
        }
        
        public Apskritimas(double laukas, double spindulys)
        {
            laukas = Laukas;
            spindulys = Spindulys;
        }

        public void SkaiciuotiPlota()
        {
            double plotas = Math.PI * Math.Pow(Spindulys, 2);
            Console.WriteLine($"Apskritimo plotas - {plotas} cm^2");
        }
        
        public void SkaiciuotiPerimetra()
        {
            double perimetras = 2 * Math.PI * Spindulys;
            Console.WriteLine($"Apsritimo perimetras - {perimetras} cm");
        }

    }
}

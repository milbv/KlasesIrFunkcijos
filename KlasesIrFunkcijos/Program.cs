using System;
namespace KlasesIrFunkcijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite amziu: ");
            Console.WriteLine(Pilnametyste(int.Parse(Console.ReadLine())));

            Console.WriteLine("Iveskite skaiciu, kurio suma noretumete gauti: ");
            Console.WriteLine(SkaiciuSudetis(int.Parse(Console.ReadLine())));

            Console.WriteLine("Iveskite temperatura: ");
            Console.WriteLine(TemperaturosVertinimas(int.Parse(Console.ReadLine())));

            Console.WriteLine("Iveskite skaiciu, noredami gauti skaiciu kvadratus iki norimo skaiciaus");
            Console.WriteLine(PakelimasKvadratu(int.Parse(Console.ReadLine())));

            Console.WriteLine("Iveskite skaiciu, iki kurio nelyginiu skaiciu suma norite gauti");
            Console.WriteLine(NelyginiuSuma(int.Parse(Console.ReadLine())));

            Console.WriteLine("Iveskite skaiciu, kad galetumete pamatyti skaicius nuo jo atbuline tvarka");
            Console.WriteLine(AtbuliniaiSkaiciai(int.Parse(Console.ReadLine())));

            Console.WriteLine("Iveskite skaiciu, kurio daliklius norite rasti: ");
            Console.WriteLine(Dalikliai(int.Parse(Console.ReadLine())));

            Automobilis automobilis1 = new Automobilis("Toyota", "Yaris", 2001, 5);
            automobilis1.PildytiKura(40);
            automobilis1.Vaziuoti(200);

            Studentas studentas1 = new Studentas("Jonas", "Jonaitis", 15, 5);
            studentas1.PridetiPazymi(6);
            studentas1.ArPerejoISekanciaKlase();

            Apskritimas apskritimas1 = new Apskritimas(30, 5);
            apskritimas1.SkaiciuotiPerimetra();
            apskritimas1.SkaiciuotiPlota();

            Knyga knyga1 = new Knyga("Kliudziau", "J. Biliunas", 140, false);
            knyga1.perskaitytiKnyga();
            knyga1.gautiAprasyma();

            BankoSaskaita saskaita1 = new BankoSaskaita("Juozas", "LT12312312", 33.15d);
            saskaita1.IdetiPinigus(22.15);
            saskaita1.NusiimtiPinigus(15.00);
            saskaita1.GautiInformacija();

            BankoSaskaita saskaita2 = new BankoSaskaita("Jurgis", "Lt11311123");
            saskaita2.IdetiPinigus(2000.19);
            saskaita1.NusiimtiPinigus(15.00);
            saskaita1.GautiInformacija();
        }

        // 1. Patikrinti pilnametystę: Sukurkite funkciją, kuri priima žmogaus amžių ir grąžina tekstą „Pilnametis“, jei amžius yra 18 ar daugiau, o kitu atveju - „Nepilnametis“.
        public static string Pilnametyste(int amzius)
        {
            if (amzius >= 18)
            {
                return "Pilnametis";
            } else
            {
               return"Nepilnametis";
            }            
        }
        // 2.Sudėti iki duoto skaičiaus: Parašykite funkciją, kuri priima sveikąjį skaičių ir grąžina visų nuo 1 iki šio skaičiaus įskaitant sudėtį (pavyzdžiui, jei įvesite 5, grąžins 15, nes 1+2+3+4+5 = 15).
        public static int SkaiciuSudetis(int skaicius)
        {
            int suma = 0;
            for (int i = 1; i <= skaicius; i++)
            {
                suma += i;
            }
            return suma;
        }
        // 3.Temperatūros vertinimas: Sukurkite funkciją, kuri priima temperatūros reikšmę ir grąžina tekstą, ar ši temperatūra yra „Šalta“ (mažiau nei 0), „Vidutinė“ (nuo 0 iki 20) ar „Karšta“ (daugiau nei 20).
        public static string TemperaturosVertinimas (int temperatura)
        {
            switch (temperatura)
            {
                case int n when (n < 0):
                   return "Salta";                  
                case int n when (n >= 0 && n <= 20):
                    return "Vidutine";    
                case int n when (n > 20):
                    return "Karsta";
                default:
                    return "";
            }
        }
        // 4.Skaičių pakėlimas kvadratu iki duotos ribos: Parašykite funkciją, kurį priima sveikąjį skaičių kaip ribą ir, naudodama ciklą, grąžina kiekvieno skaičiaus nuo 1 iki šios ribos kvadratus (pvz., jei riba yra 3, grąžins 1, 4, 9).
        public static string PakelimasKvadratu (int skaicius)
        {
            string a = "";
            for (int i = 1; i <= skaicius; i++)
            {
                if (i == skaicius)
                {
                    a += $"{Math.Pow(i, 2)}.";
                } else {
                    a += $"{Math.Pow(i, 2)}, ";
                }
            }
            return a;
        }
        // 5.Rasti nelyginių skaičių sumą iki ribos: Parašykite funkciją, kuri priima sveikąjį skaičių kaip ribą ir grąžina visų nelyginių skaičių nuo 1 iki šios ribos sumą.
        public static int NelyginiuSuma (int skaicius)
        {
            int suma = 0;
            for (int i = 1; i <= skaicius; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            return suma;
        }
        // 6.Atspausdinti skaičius atbuline tvarka: Sukurkite funkciją, kuri priima sveikąjį skaičių kaip ribą ir atspausdina skaičius nuo šios ribos iki 1 atbuline tvarka.
        public static string AtbuliniaiSkaiciai (int skaicius)
        {
            string a = "";
            for (int i = skaicius; i >= 1; i--)
            {
                a += $"{i}, ";
            }
            return a;
        }
        // 7.Rasti daliklius iki ribos: Parašykite funkciją, kuri priima sveikąjį skaičių kaip ribą ir atspausdina visus šio skaičiaus daliklius nuo 1 iki pačios ribos.
        public static string Dalikliai (int skaicius)
        {
            string a = "";
            for (int i = 1; i <= skaicius; i++)
            {
                if (skaicius % i == 0)
                {
                    a += $"{i} ,";
                }
            }
            return a;
        }

    }
}

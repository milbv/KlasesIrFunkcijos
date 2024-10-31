using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesIrFunkcijos
{
    public class BankoSaskaita
    {
        public string SavinininkoVardas { get; set; }
        public string SaskaitosNumeris { get; set; }
        public double Balansas { get; set; } = 0d;

        public BankoSaskaita(string savininkoVardas, string saskaitosNumeris, double balansas)
        {
            SavinininkoVardas = savininkoVardas;
            SaskaitosNumeris = saskaitosNumeris;
            Balansas = balansas;
        }

        public BankoSaskaita(string savininkoVardas, string saskaitosNumeris)
        {
            SavinininkoVardas = savininkoVardas;
            SaskaitosNumeris = saskaitosNumeris;
        }
        public BankoSaskaita()
        { 
        }

        public void IdetiPinigus(double suma)
        {
            Balansas += suma;
            Console.WriteLine("Siuo metu saskaitoje turite: " + Balansas);
        }
        public void NusiimtiPinigus(double suma)
        {
            Balansas -= suma;
            Console.WriteLine("Siuo metu saskaitoje turite: " + Balansas);
        }
        public void GautiInformacija()
        {
            Console.WriteLine($"Sios saskaitos numerio savininkas yra {SavinininkoVardas}. Saskaitos balansas yra: {Balansas}");
        }
    }
}

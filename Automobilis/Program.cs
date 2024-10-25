using System;
namespace Automobilis
{
    /* 8. Klasė "Automobilis"
       Sukurkite klasę Automobilis, kurioje būtų:
       Laukai: marke, modelis, metai, ir kuroLikutis (litrais).
       Funkcija pildytiKura(double kiekis), kuri prideda nurodytą kiekį kuro prie kuroLikutis.
       Funkcija vaziuoti(double atstumas), kuri sumažina kuro likutį pagal važiuotą atstumą (laikykite, kad automobilis sunaudoja 1 litrą kuro 10 km).
       Papildoma praktika: Parašykite Automobilis konstruktorių, kuris nustato pradinę markę, modelį ir metus.
   */
    public class Automobilis
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Metai { get; set; }
        public int KuroLikutis { get; set; }
    }
    /*
      9. Klasė "Studentas"
Sukurkite klasę Studentas, kurioje būtų:
Laukai: vardas, pavarde, amzius, ir vidurkis.
Funkcija pridetiPazymi(double pazymys), kuri atnaujina studento vidurkį pridedant naują pažymį.
Funkcija arPerejoISekanciaKlase(), kuri grąžina true, jei vidurkis yra 5 ar daugiau, ir false kitu atveju.
Papildoma praktika: Parašykite Studentas konstruktorių, kuris nustato pradinį vardą, pavardę ir amžių.
10. Klasė "Apskritimas"
Sukurkite klasę Apskritimas, kurioje būtų:
Laukas spindulys.
Funkcija skaiciuotiPlota(), kuri grąžina apskritimo plotą (naudokite formulę π⋅spindulys2\pi \cdot spindulys^2π⋅spindulys2).
Funkcija skaiciuotiPerimetra(), kuri grąžina apskritimo perimetrą (naudokite formulę 2⋅π⋅spindulys2 \cdot \pi \cdot spindulys2⋅π⋅spindulys).
Papildoma praktika: Pridėkite konstruktorų, leidžiančių sukurti Apskritimas objektą su nurodytu spinduliu.
11. Klasė "Knyga"
Sukurkite klasę Knyga, kurioje būtų:
Laukai: pavadinimas, autorius, puslapiuSkaicius, arPerskaityta (boolean).
Funkcija perskaitytiKnyga(), kuri nustato arPerskaityta reikšmę kaip true.
Funkcija gautiAprasyma(), kuri grąžina tekstinę informaciją apie knygą, įskaitant jos pavadinimą, autorių ir puslapių skaičių.
Papildoma praktika: Sukurkite konstruktorių, kuris nustato knygos pavadinimą, autorių ir puslapių skaičių.
12.Klasė "BankoSaskaita"
Sukurkite klasę BankoSaskaita, kurioje būtų:
Laukai: savininkoVardas, saskaitosNumeris, balansas.
Funkcija idetiPinigus(double suma), kuri prideda nurodytą sumą prie balanso.
Funkcija nusiimtiPinigus(double suma), kuri sumažina balansą nurodyta suma, jei balanse yra pakankamai pinigų. Jei nepakanka, grąžina klaidos pranešimą.
Funkcija gautiInformacija(), kuri grąžina informaciją apie sąskaitos savininką ir balansą.
Papildoma praktika: Parašykite BankoSaskaita konstruktorių, kuris inicializuoja savininko vardą ir sąskaitos numerį.
     */
}

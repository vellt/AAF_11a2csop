using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kettes
{
    enum Szamolj
    {
        Kotojel,
        Otos,
        Betu,
        Sbetu,
        Special
    }

    enum Karakter
    {
        Szam, Betu, EBetu
    }
    class Program
    {
        static int Mennyi(string szoveg, Szamolj szamit)
        {
            switch (szamit)
            {
                case Szamolj.Kotojel:
                    int szam = 0;

                    for (int i = 0; i < szoveg.Length; i++)
                    {
                        if (szoveg[i] == 45)
                        {
                            szam++;
                        }
                    }
                    return szam;


                case Szamolj.Otos:
                    int szam2 = 0;

                    for (int i = 0; i < szoveg.Length; i++)
                    {
                        if (szoveg[i] == 53)
                        {
                            szam2++;
                        }
                    }
                    return szam2;

                case Szamolj.Betu:
                    int szam3 = 0;

                    for (int i = 0; i < szoveg.Length; i++)
                    {
                        if (szoveg[i] >= 97 && szoveg[i] <= 122 || szoveg[i] >= 65 && szoveg[i] <= 90)
                        {
                            szam3++;
                        }
                    }
                    return szam3;
                case Szamolj.Sbetu:
                    int szam4 = 0;
                    for (int i = 0; i < szoveg.Length; i++)
                    {
                        char karakter = szoveg[i];
                        if (karakter==83 || karakter==115)
                        {
                            szam4++;
                        }
                    }
                    return szam4;
                case Szamolj.Special:
                    return 0;
                default:
                    return 0;
            }
        }

        static int MennyiSzazalek(string szoveg, Karakter karakter)
        {
            switch (karakter)
            {
                case Karakter.Szam:
                    int szamlalo = 0;
                    for (int i = 0; i < szoveg.Length; i++)
                    {
                        char kar = szoveg[i];
                        if (kar>=48 && kar<=57)
                        {
                            szamlalo++;
                        }
                    }
                    ;
                    return (int)Math.Round((szamlalo / (double)szoveg.Length)*100);
                case Karakter.Betu:
                    return 0;
                case Karakter.EBetu:
                    return 0;
                default: return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Mennyi("ABC123", Szamolj.Betu));
            Console.WriteLine(MennyiSzazalek("ABC123", Karakter.Szam));
            Console.ReadKey();
        }
    }
}

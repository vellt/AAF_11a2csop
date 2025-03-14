using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp159
{
    enum GeometriaiMennyiseg2D { Kerulet, Terulet }
    enum GeometriaiMennyiseg3D { Terfogat, Felszin }
    enum Kerekites { KetTizedes, NegyTizedes }
    enum Mennyi { Szokoz, Nagybetu, Kisbetu, Szam, Maganhanzo }
    enum Van { Pont, Vesszo, Felkialtojel }
    class Program
    {
        static double Teglatest(double a, double b, double c, GeometriaiMennyiseg3D mennyiseg)
        {
            double eredmeny = 0;

            switch (mennyiseg)
            {
                case GeometriaiMennyiseg3D.Terfogat:
                    eredmeny = a * b * c;
                    break;
                case GeometriaiMennyiseg3D.Felszin:
                   eredmeny = 2 * (a * b + b * c + c * a);
                    break;
                
            }
            return eredmeny;
        } 

        static double Teglatest(double a, double b, double c, GeometriaiMennyiseg3D mennyiseg, Kerekites kerekites)
        {

            double eredmeny = 0;

            switch (mennyiseg)
            {
                case GeometriaiMennyiseg3D.Terfogat:
                    eredmeny = a * b * c;
                    break;
                case GeometriaiMennyiseg3D.Felszin:
                    eredmeny = 2 * (a * b + b * c + c * a);
                    break;

            }
            switch (kerekites)
            {
                case Kerekites.KetTizedes:
                    eredmeny = Math.Round(eredmeny, 2);
                    break;
                case Kerekites.NegyTizedes:
                    eredmeny = Math.Round(eredmeny, 4);
                    break;

            }
            return eredmeny;
        } 
           
            
        static double Kor(double r, GeometriaiMennyiseg2D mennyiseg, Kerekites kerekites)
        {
            double eredmeny = 0;
            switch (mennyiseg)
            {
                case GeometriaiMennyiseg2D.Kerulet:
                    eredmeny = r * r * Math.PI;
                    break;
                case GeometriaiMennyiseg2D.Terulet:
                    eredmeny = 2 * r * Math.PI;
                    break;
            }

            switch (kerekites)
            {
                case Kerekites.KetTizedes:
                    eredmeny = Math.Round(eredmeny, 2);
                    break;
                case Kerekites.NegyTizedes:
                    eredmeny = Math.Round(eredmeny, 4);
                    break;
            }

            return eredmeny;
        }

        static double Kor(double r,GeometriaiMennyiseg2D mennyiseg)
        {
            double eredmeny = 0;
            switch (mennyiseg)
            {
                case GeometriaiMennyiseg2D.Kerulet:
                    eredmeny = r * r * Math.PI;
                    break;
                case GeometriaiMennyiseg2D.Terulet:
                    eredmeny = 2 * r * Math.PI;
                    break;
                default:
                    eredmeny = 0; break;
            }
            return eredmeny;
        }

        static int Statisztika(string szoveg, Mennyi mennyi)
        {
            switch (mennyi)
            {
                case Mennyi.Szokoz:
                    int szokoz = 0;
                    for (int i = 0; i < szoveg.Length; i++)
                    {
                        if (szoveg[i] == 32)
                        {
                            szokoz++;
                        }
                    }
                    return szokoz;
                case Mennyi.Nagybetu:
                    int nagyb = 0;
                    for (int i = 0; i < szoveg.Length; i++)
                    {
                        if (szoveg[i] >= 65 && szoveg[i] <= 90)
                        {
                            nagyb++;
                        }
                    }
                    return nagyb;
                case Mennyi.Kisbetu:
                    int kisb = 0;
                    for (int i = 0; i < szoveg.Length; i++)
                    {
                        if (szoveg[i] >= 97 && szoveg[i] <= 122)
                        {
                            kisb++;
                        }
                    }
                    return kisb;
                case Mennyi.Szam:
                    int szam = 0;
                    for (int i = 0; i < szoveg.Length; i++)
                    {
                        if (szoveg[i] >= 48 && szoveg[i] <= 57)
                        {
                            szam++;
                        }
                    }
                    return szam;
                case Mennyi.Maganhanzo:
                    int maganh = 0;
                    string maganhangzok = "aeiou";
                    for (int i = 0; i < szoveg.ToLower().Length; i++)
                    {
                        char k = szoveg[i];
                        if (maganhangzok.Contains(k))
                        {
                            maganh++;
                        }
                    }
                    return maganh;
                default:
                    return 0;
            }

        }

        static bool Statisztika(string szoveg, Van van)
        {
            switch (van)
            {
                case Van.Pont:
                    bool vanPont = false;
                    for (int i = 0; i < szoveg.Length && vanPont==false; i++)
                    {
                        if (szoveg[i] == 46)
                        {
                            vanPont = true;
                        }
                    }
                    return vanPont;
                    
                case Van.Vesszo:
                    bool vanVesszo = false;
                    for (int i = 0; i < szoveg.Length && vanVesszo==false; i++)
                    {
                        if (szoveg[i] == 44)
                        {
                            vanVesszo = true;
                        }
                    }
                    return vanVesszo;
                    
                case Van.Felkialtojel:
                    bool vanFelk = false;
                    for (int i = 0; i < szoveg.Length && vanFelk==false; i++)
                    {
                        if (szoveg[i] == 33)
                        {
                            vanFelk = true;
                        }
                    }
                    return vanFelk;
                default:
                    return false;
                
            }
        }

        static void Main(string[] args)
        {
           
            Console.WriteLine(Kor(20.8, GeometriaiMennyiseg2D.Kerulet));
            Console.WriteLine(Kor(20.8, GeometriaiMennyiseg2D.Kerulet, Kerekites.KetTizedes));
            Console.WriteLine(Kor(20.8, GeometriaiMennyiseg2D.Kerulet, Kerekites.NegyTizedes));

            Console.WriteLine(Kor(20.8, GeometriaiMennyiseg2D.Terulet));
            Console.WriteLine(Kor(20.8, GeometriaiMennyiseg2D.Terulet, Kerekites.KetTizedes));
            Console.WriteLine(Kor(20.8, GeometriaiMennyiseg2D.Terulet, Kerekites.NegyTizedes));

            string szoveg = "A C# 2.0-s verziotol felfele mar rendelkezik generikus programozasi eszkozokkel.";

            Console.WriteLine(Statisztika(szoveg, Mennyi.Kisbetu));
            Console.WriteLine(Statisztika(szoveg, Mennyi.Nagybetu));
            Console.WriteLine(Statisztika(szoveg, Mennyi.Maganhanzo));
            Console.WriteLine(Statisztika(szoveg, Mennyi.Szam));
            Console.WriteLine(Statisztika(szoveg, Mennyi.Szokoz));
            Console.WriteLine();

            Console.WriteLine(Statisztika(szoveg, Van.Felkialtojel));
            Console.WriteLine(Statisztika(szoveg, Van.Pont));
            Console.WriteLine(Statisztika(szoveg, Van.Vesszo));

            Console.ReadKey();
        }
    }
}

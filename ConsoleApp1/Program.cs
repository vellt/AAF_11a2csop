using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Karakter
    {
        MondatvegiIrasjel, Massalhangzo, Maganhangzo,
        Szam, Betu, Kisbetu, Nagybetu
    }
    class Program
    {
        static bool Van(string szoveg, Karakter karakter)
        {
            switch (karakter)
            {
                case Karakter.MondatvegiIrasjel:
                    return false;
                case Karakter.Massalhangzo:
                    bool van1 = false;
                    for (int i = 0; i < szoveg.Length && van1==false; i++)
                    {
                        char kar = szoveg[i];
                        if (kar>=97 && kar<=122 || kar>=65 && kar<=90 && 
                            !(
                            kar == 97 || kar == 65 || kar == 101 || kar == 69 || kar == 105 ||
                            kar == 73 || kar == 111 || kar == 79 || kar == 117 || kar == 85
                            ))
                        {
                            van1 = true;
                        }
                    }
                    return van1;
                case Karakter.Maganhangzo:
                    bool van = false;
                    for (int i = 0; i < szoveg.Length && van==false; i++)
                    {
                        char kar = szoveg[i];
                        if (
                            kar==97 || kar==65 || kar==101 || kar==69 || kar==105 ||
                            kar==73 || kar==111 || kar==79 || kar==117 || kar==85 
                            )
                        {
                            van = true;
                        }
                    }
                    return van;
                default:
                    return false;
            }
        }

        static bool Mindegyik(string szoveg, Karakter karakter)
        {
            switch (karakter)
            {
                case Karakter.Szam:
                    bool osszes = true;
                    for (int i = 0; i < szoveg.Length && osszes==true; i++)
                    {
                        if (!(szoveg[i]>=48 && szoveg[i]<=57))
                        {
                            osszes = false;
                        }
                    }
                    return osszes;
                case Karakter.Betu:
                    return false;
                case Karakter.Kisbetu:
                    return false;
                case Karakter.Nagybetu:
                    return false;
                default:
                    return false;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Van("ABC123", Karakter.Maganhangzo));
            Console.WriteLine(Mindegyik("ABC123", Karakter.Szam));
            Console.ReadKey();
        }
    }
}

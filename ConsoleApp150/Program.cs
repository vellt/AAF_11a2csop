using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp150
{
    /// <summary>
    /// 2. oldal 2. feladatához
    /// </summary>
    enum NevResz
    {
        Keresztnev, Vezeteknev
    }
    class Program
    {
        /// <summary>
        /// 0. feladat
        /// </summary>
        static string TeljesNev(string veznev,string kernev)
        {
            return $"{veznev} {kernev}";
        }

        //--------------------------------------------------------------


        /// <summary>
        /// 1. feladat: a
        /// </summary>
        static int Hossz(string szoveg)
        {
            return szoveg.Length;
        }

        /// <summary>
        /// 1. feladat: b
        /// </summary>
        static int Hossz(int[] tomb)
        {
            return tomb.Length;
        }

        /// <summary>
        /// 1. feladat: c
        /// </summary>
        static int Hossz(string[] tomb)
        {
            return tomb.Length;
        }

        //--------------------------------------------------------------

        /// <summary>
        /// 2. feladat
        /// </summary>
        static int SzamokMennyisege(string szoveg)
        {
            int db = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if(szoveg[i]>=48 && szoveg[i] <= 57) // szám
                {
                    db++;
                }
            }
            return db;
        }

        //--------------------------------------------------------------

        /// <summary>
        /// 3. feladat
        /// </summary>
        static int NagybetukMennyisege(string szoveg)
        {
            int db = 0;
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i] >= 65 && szoveg[i] <= 90) // nagybetű
                {
                    db++;
                }
            }
            return db;
        }

        //--------------------------------------------------------------

        /// <summary>
        /// 4. feladat: a
        /// </summary>
        static string ElsoElem(string[] szoveg)
        {
            return szoveg[0];
        }

        /// <summary>
        /// 4. feladat: b
        /// </summary>
        static string ElsoElem(string tomb)
        {
            return tomb[0].ToString();
        }

        /// <summary>
        /// 4. feladat: c
        /// </summary>
        static string ElsoElem(int[] tomb)
        {
            return tomb[0].ToString();
        }

        //--------------------------------------------------------------

        /// <summary>
        /// 5. feladat: a
        /// </summary>
        static string ForditottAlak(string szoveg)
        {
            string forditott = "";
            for (int i = szoveg.Length - 1; i >= 0; i--)
            {
                forditott += szoveg[i];
            }
            return forditott;
        }

        /// <summary>
        /// 5. feladat: b
        /// </summary>
        static int[] ForditottAlak(int[] tomb)
        {
            int[] forditott = new int[tomb.Length];
            for (int i = tomb.Length - 1, j = 0; i >= 0; i--, j++)
            {
                forditott[j] = tomb[i];
            }
            return forditott;
        }

        /// <summary>
        /// 5. feladat: c
        /// </summary>
        static string[] ForditottAlak(string[] tomb)
        {
            string[] forditott = new string[tomb.Length];
            for (int i = tomb.Length - 1, j = 0; i >= 0; i--, j++)
            {
                forditott[j] = tomb[i];
            }
            return forditott;
        }

        //--------------------------------------------------------------

        /// <summary>
        /// 6. feladat: a
        /// </summary>
        static void TombKiiratasa(int[] tomb)
        {
            foreach (var item in tomb)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 6. feladat: b
        /// </summary>
        static void TombKiiratasa(string[] tomb)
        {
            foreach (var item in tomb)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        //--------------------------------------------------------------

        /// <summary>
        /// 8. feladat
        /// </summary>
        static string Nagybetus(string szoveg)
        {
            string nagybetus = "";

            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i]>=97 && szoveg[i]<=122) // kisbetűs
                {
                    nagybetus += (char)(szoveg[i] - 32);
                }
                else
                {
                    nagybetus += szoveg[i]; // szám, nagybetűs, spec karakter
                }
            }

            return nagybetus;
        }

        //--------------------------------------------------------------

        /// <summary>
        /// 2. oldal 2-es feladata
        /// </summary>
        static string Nev(string teljesNev, NevResz nevResz)
        {
            switch (nevResz)
            {
                case NevResz.Keresztnev: return teljesNev.Split(' ')[1];
                case NevResz.Vezeteknev: return teljesNev.Split(' ')[0];
                default: return teljesNev;   
            }
        }

        static void Main(string[] args)
        {
            // 0
            Console.WriteLine(TeljesNev("Szántó", "Benjámin")); // Szántó Benjámin

            // 1
            Console.WriteLine(Hossz("Szia")); // 4
            Console.WriteLine(Hossz(new int[] { 1, 2, 3 })); // 3
            Console.WriteLine(Hossz(new string[] { "Alma", "Körte" })); // 2

            // 2
            Console.WriteLine(SzamokMennyisege("A skandináv lotto 5 számát 4 ember kitalálta")); // 2
            
            // 3
            Console.WriteLine(NagybetukMennyisege("A SKANDINAV lotto 5 számát 4 ember kitalálta")); // 10
            
            // 4
            Console.WriteLine(ElsoElem("Szia")); // S
            Console.WriteLine(ElsoElem(new int[] { 1, 2, 3 })); // 1
            Console.WriteLine(ElsoElem(new string[] { "Alma", "Körte" })); // Alma
            
            // 5
            Console.WriteLine(ForditottAlak("ALMA")); // AMLA
            foreach (var item in ForditottAlak(new string[]{"ALMA", "KÖRTE", "BARACK"}))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(); // "BARACK", "KÖRTE", "ALMA" 
            foreach (var item in ForditottAlak(new int[] { 1, 2, 3 }))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(); // 3, 2, 1

            // 6
            TombKiiratasa(new int[] { 1, 2, 3 }); // 1 2 3
            TombKiiratasa(new string[] { "ALMA", "KÖRTE", "BARACK" }); // ALMA KÖRTE BARACK

            // 8
            Console.WriteLine(Nagybetus("az Almafat 4x vagtak ki az iden")); // AZ ALMAFAT 4X VAGTAK KI AZ IDEN

            // 2. oldal 2-es feladata
            Console.WriteLine(Nev("Szántó Benjámin", NevResz.Keresztnev)); // Benjámin
            Console.WriteLine(Nev("Szántó Benjámin", NevResz.Vezeteknev)); // Szántó

            Console.ReadKey();
        }
    }
}

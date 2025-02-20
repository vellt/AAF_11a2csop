using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp144
{
    class Konzol
    {
        public static void Kiir(string szoveg)
        {
            Console.WriteLine(szoveg);
        }

        public static void Kiir(int szoveg)
        {
            Console.WriteLine(szoveg);
        }
    }
    class Program
    {
        // példa 1: paraméter nélküli függvény
        static string Koszones()
        {
            return "Szia Ottó";
        }

        // példa 2: a példa 1 túltöltése: paraméteres függvény
        static string Koszones(string nev)
        {
            return $"Szia {nev}";
        }

        // feladat 1: három paraméterből (szám1, szám2, szám3) adja vissza a legnagyobbat. Neve : Legnagyobb
        static int Legnagyobb(int szam1, int szam2, int szam3)
        {
            int max = szam1;
            if (szam2 > max)
            {
                max = szam2;
            }
            else if (szam3 > max)
            {
                max = szam3;
            }
            return max;
        }
        static void Main(string[] args)
        {
            // metódus túltöltések
            Console.WriteLine(6);
            Console.WriteLine("6");
            Console.WriteLine('6');
            Console.WriteLine(true);

            // egyedi kiíratás
            Console.WriteLine("hello world"); // szöveget fogad
            Console.WriteLine(4); // számot fogad
            Konzol.Kiir("sss"); // szöveget fogad
            Konzol.Kiir(4); // számot fogad

            // példában szereplő függvény meghívása
            Console.WriteLine(Koszones()); // kiírja h szia Ottó, nincs paramétere
            Console.WriteLine(Koszones("Bátyus")); // kiírja, hogy szia Bátyus, a Bátyust a paraméterből kapja

            // feladat 1 meghívása, és tesztelése. A 3 szám közül kiadja a legnagyobbat
            int max = Legnagyobb(6, 5, 10);
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}

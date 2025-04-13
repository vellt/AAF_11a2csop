using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp177
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3x4-es mátrix készítése
            int[,] matrix = new int[3,4];
            // sorok számának lekérdezése
            Console.WriteLine(matrix.GetLength(0));
            // oszlopok számának lekérdezése
            Console.WriteLine(matrix.GetLength(1));

            // értékeinek kiíratása (rendezetten)
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j],4}");
                }
                Console.WriteLine();
            }

            // [-10, 10]-ben feltöltés
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(-10, 11);
                }
            }

            Console.WriteLine();

            // 1. feladat: minden sor összegének a kiíratása
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int osszeg = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    osszeg += matrix[i, j];
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine($" = {osszeg}");
            }

            // 2. feladat kérjünk be egy sor, és oszlop értéket, és mondjuk meg
            // milyen elem van ott a mátrixban
            Console.Write("Sor: ");
            int sor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oszlop: ");
            int oszlop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Szám: {matrix[sor, oszlop]}");

            // 3. feladat: azon sorok indexének a kiíratása, melyekben az elemek mind pozitivak
            // (néztük nagyon kicsi rá az esély, de megvan a random miatt, hogy minden eleme egy sornak pozitív legyen)
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool igen = true;
                for (int j = 0; j < matrix.GetLength(1) && igen==true; j++)
                {
                    int szam = matrix[i, j];
                    if (szam<0)
                    {
                        igen = false;
                    }
                }
                if (igen)
                {
                    Console.WriteLine($"minden elem pozitiv a {i}. sorban");
                }
            }

            // 4. feladat: A mátrix legnagyobb és legkisebb értéke
            int max = matrix[0, 0];
            int min = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 && j==0)
                    {
                        j++;
                    }

                    int szam = matrix[i, j];

                    if (max<szam)
                    {
                        max = szam;
                    }

                    if (min>szam)
                    {
                        min = szam;
                    }
                }
            }
            Console.WriteLine($"Mátrix legkisebb értéke: {min}");
            Console.WriteLine($"Mátrix legnagyobb értéke: {max}");
            Console.ReadKey();
        }
    }
}

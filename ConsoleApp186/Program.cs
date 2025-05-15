using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp186
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3x2-es mátrix létrehozása, és feltöltése [10,20]-ban
            int[,] matrix = new int[3, 2];
            Random r = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(10, 21);
                }
            }
            // mátrix elemeinek kiíratása soronként
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            //Egy meteorológiai állomás egy év minden hónapjában (12 hónap), 
            //30 napon keresztül mérte a napi csapadékmennyiséget mm-ben. 
            //A csapadékmennyiség legyen véletlenszerű [0,20] mm között.
            int[,] csapadekok = new int[12, 30];
            for (int i = 0; i < csapadekok.GetLength(0); i++)
            {
                for (int j = 0; j < csapadekok.GetLength(1); j++)
                {
                    csapadekok[i, j] = r.Next(21); // [0,20]
                }
            }

            // Hány napon volt eső (tehát a csapadék > 0)?
            int szamlalo = 0;
            for (int i = 0; i < csapadekok.GetLength(0); i++)
            {
                for (int j = 0; j < csapadekok.GetLength(1); j++)
                {
                    int napiCsapadekMennyiseg = csapadekok[i, j];
                    if (napiCsapadekMennyiseg>0)
                    {
                        szamlalo++;
                    }
                }
            }
            Console.WriteLine(szamlalo);

            // Melyik hónapban volt a legtöbb csapadék?
            int index = 0;
            int csapadekMennyiseg = 0;
            for (int i = 0; i < csapadekok.GetLength(0); i++)
            {
                int osszCsapadek = 0; // az adott hónapnak
                for (int j = 0; j < csapadekok.GetLength(1); j++)
                {
                    osszCsapadek += csapadekok[i, j];
                }
                if (csapadekMennyiseg<osszCsapadek)
                {
                    csapadekMennyiseg = osszCsapadek;//aktuáis honap csapadekja
                    index = i;// aktuális hónap
                }
            }
            Console.WriteLine($"{index+1}. honapban volt a legnagyobb {csapadekMennyiseg}");

            // Egy osztály 5 tantárgyból írt dolgozatokat (matek, magyar, töri, angol, biosz).
            // Minden tantárgyból 6 dolgozat született. 
            // A pontszámokat[0, 50] között rögzítették egy 5×6 - os mátrixba.
            int[,] Jegyek = new int[5, 6];
            int tan = 0;
            double atlag = 0;
            for (int i = 0; i < Jegyek.GetLength(0); i++)
            {
                int osszes = 0;
                
                for (int j = 0; j < Jegyek.GetLength(1); j++)
                {
                    Jegyek[i, j] = r.Next(51);
                    osszes += Jegyek[i, j];
                }
                double batlag = osszes / Jegyek.GetLength(1);
                if(batlag> atlag)
                {
                    tan = i;
                    atlag = batlag;
                }
            }
            // Melyik tantárgyból született a legmagasabb átlag?   
            Console.WriteLine($"{tan}. tárgyból lett a legmagasabb átlag: {atlag}");

            // Hány dolgozat lett elégtelen(25 pont alatti)?
            int egyes = 0;
            for (int i = 0; i < Jegyek.GetLength(0); i++)
            {
                for (int j = 0; j < Jegyek.GetLength(1); j++)
                {
                    if (Jegyek[i, j] < 25) egyes++;
                }
            }
            Console.WriteLine($"{egyes} db dolgozat volt elégtelen");

            // 3x3-as mátrixot tölts fel [1,9]-ban. Soronként írasd ki az értékekeit
            // majd írd ki, hogy melyik sornak mennyi az összege
            int[,] matrix2 = new int[3, 3];
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                int osszeg = 0;
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = r.Next(1,10); //[1,9]
                    osszeg += matrix2[i, j];
                    Console.Write(matrix2[i,j]+" ");
                }
                Console.WriteLine();
                Console.WriteLine($"{i}. sor összege: {osszeg}");
            }

            // kérj be egy sort és egy oszlopot, majd írasd ki az indexek alapján
            // a mátrix értékét
            Console.Write("Sor: ");
            int sor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Oszlop: ");
            int oszlop= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(matrix2[sor, oszlop]);


            Console.ReadKey();
        }
    }
}

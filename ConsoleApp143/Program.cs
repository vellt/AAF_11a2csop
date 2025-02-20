using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp143
{
    class Program
    {
       
        static void Main()
        {
            // Adott 4 szám:
            int sz1 = 65;
            int sz2 = 76;
            int sz3 = 77;
            int sz4 = 65;
            // nézzük meg kiírva őket
            Console.WriteLine($"{sz1} {sz2} {sz3} {sz4}");
            // majd nézzük meg char kasztolással a kiíratás hogyan változott a felsőhöz képest, és miért? Válasz: ASCII
            Console.WriteLine($"{(char)sz1} {(char)sz2} {(char)sz3} {(char)sz4}");

            // írjuk ki a nagybetűs (angolszász) ABC karaktereit, ábécé szerint növekvő sorrendben
            for (int i = 65; i <= 90; i++)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine();

            // írjuk ki a nagybetűs (angolszász) ABC karaktereit, ábécé szerint csökkenő sorrendben
            for (int i = 90; i >= 65; i--)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine();

            // mivel egy számnak (char) kasztolással ki tudjuk nyerni a karakter alakját
            // akkor valószínűleg minden karakternek is kikényszerhetjük az ASCII decimális értékét-->(int) kasztolás
            Console.WriteLine('a'); // a
            Console.WriteLine((int)'a'); // 97

            Console.WriteLine('A'); // A
            Console.WriteLine((int)'A'); // 65

            // a cél, hogy egy ToLower vagy ToUpper függvényt tudjunk majd implementálni
            Console.WriteLine($"ALMA-->{("ALMA".ToLower())}"); // ALMA-->alma

            // kérjünk be egy karaktert a felhasználótól és döntsük el az ASCII kódtábla segítségével
            // hogy a bekért karakter szám, nagybetű vagy kisbetű
            Console.Write("Adj egy karaktert: ");
            char karakter = Convert.ToChar(Console.ReadLine()); // bekérjük a karaktert
            int ascii = (int)karakter; // kinyerjük az ASCII kód decimális értékét
            if (ascii>=48 && ascii<=57)
            {
                Console.WriteLine("Szám");
            } else if (ascii >=65 && ascii <= 90)
            {
                Console.WriteLine("Nagybetű");
            } else if (ascii>=97 && ascii<= 122)
            {
                Console.WriteLine("Kisbetű");
            }
            else
            {
                Console.WriteLine("valami más");
            }

            // [megszámlálás tétele]
            // Kérj be egy szöveget, majd számold meg mennyi szám, kis- és nagybetűs karakter van benne.
            Console.Write("Adj meg egy szöveget: ");
            string bekertSzoveg = Console.ReadLine();

            int szam = 0;
            int nagybetu = 0;
            int kisbetu = 0;
            for (int i = 0; i < bekertSzoveg.Length; i++)
            {
                char karakter2 = bekertSzoveg[i]; // kinyerünk egy-egy karaktert a szövegből
                int ascii2 = (int)karakter2; // a karakternek meg az ASCII kódját
                if (ascii2 >= 48 && ascii2 <= 57)
                {
                    szam++;
                }
                if (ascii2 >= 65 && ascii2 <= 90)
                {
                    nagybetu++;
                }
                if (ascii2 >= 97 && ascii2 <= 122)
                {
                    kisbetu++;
                }
            }
            Console.WriteLine($"Szám: {szam}db");
            Console.WriteLine($"Nagybetű: {nagybetu}db");
            Console.WriteLine($"Kisbetű: {kisbetu}db");

            Console.ReadKey();
        }
    }
}

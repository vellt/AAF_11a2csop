using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp178
{
    class Palya
    {
        public class Jatekos
        {
            public static int lepesekSzama = 0;
            public static int sor = 6;
            public static int oszlop = 0;
            public static void Jobb()
            {
                if (matrix[sor, (oszlop + 1) % 5] != '█')
                {
                    oszlop = (oszlop + 1) % 5;
                    lepesekSzama++;
                }
                
            }

            public static void Bal()
            {
                if (matrix[sor, ((oszlop - 1) + 5) % 5] != '█')
                {
                    oszlop = ((oszlop - 1) + 5) % 5;
                    lepesekSzama++;
                }
                
            }

            public static void Fent()
            {
                if (matrix[((sor - 1) + 7) % 7, oszlop] != '█')
                {
                    sor = ((sor - 1) + 7) % 7;
                    lepesekSzama++;
                }
                
            }

            public static void Lent()
            {
                if (matrix[(sor + 1) % 7, oszlop] != '█' && (sor + 1) % 7 != 0)
                {
                    sor = (sor + 1) % 7;
                    lepesekSzama++;
                }
                
            }

            public static bool Nyert()
            {
                return sor==0;
            }
        }
        static char[,] matrix =
        {
            {' ', ' ', ' ', ' ', ' ' },
            {'█', ' ', '█', '█', '█' },
            {' ', ' ', ' ', ' ', ' ' },
            {'█', '█', ' ', '█', '█' },
            {' ', ' ', ' ', ' ', ' ' },
            {'█', '█', '█', ' ', '█' },
            {' ', ' ', ' ', ' ', ' ' },
        };
        public static void Kirajzol()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i==Jatekos.sor && j==Jatekos.oszlop)
                    {
                        Console.Write('o'); // jatékos!
                    }
                    else
                    {
                        Console.Write(matrix[i,j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            while (!Palya.Jatekos.Nyert())
            {
                Console.Clear();
                Palya.Kirajzol();
                Console.WriteLine($"lépések: {Palya.Jatekos.lepesekSzama} db");
                switch (Console.ReadKey(true).Key) // true a ReadKeyben: nem fog látszódni a konzolon a karakterleütés
                {
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Palya.Jatekos.Jobb();
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Palya.Jatekos.Bal();
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Palya.Jatekos.Fent();
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Palya.Jatekos.Lent();
                        break;
                }
            }
            Console.Clear();
            Palya.Kirajzol();
            Console.WriteLine("NYERTÉL!");
            Console.ReadKey();
        }
    }
}

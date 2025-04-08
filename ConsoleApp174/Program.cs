using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp174
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                {66, 5, 4, 10},
                {-2, 6, 6, 32},
                {84, 4, 3, 2 }
            };
            Console.WriteLine(matrix[2,2]); //3
            Console.WriteLine(matrix[1,0]); //-2

            // mennyi sor
            int sor = matrix.GetLength(0);
            // mennyi oszlop
            int column = matrix.GetLength(1);

            // 4x5
            int[,] matrix2 = new int[4, 5];
            Random r = new Random();
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] += r.Next(40, 61);
                }
            }
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write($"{matrix2[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // a hónap minden napján megmértük a hőmérsékletet egy éven kersztül
            // 1hó-->30nap. A napokat [-10, 10]-ban töltsük fel
            // a) mennyi az átlaghőmérséklet
            // b) mennyi olyan hónap volt, ahol -3 fok alatti az átlaghőm-e
            // c) mennyi az éves átlaghőméséklet

            // iskolai csoportverseny volt. 2x10 fős csoport volt
            // töltse fel [1,10]-ban az elemeket, és válaszoljon az alabbi kérdésekre
            // a) melyik csoport szerzett több pontot
            // b) mennyi tanuló szerzett az 1. csoportból 1 pontot
            // c) volt-e a 2. csoportban olyan aki 10 pontot szerzett

            char[,] matrix4 = new char[5, 5];
            for (int i = 0; i < matrix4.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4.GetLength(1); j++)
                {
                    matrix4[i,j] = 'O';
                    Console.Write($"{matrix4[i,j],3}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //d
            for (int i = 0; i < matrix4.GetLength(0); i++)
            {
                for (int j = 0; j < matrix4.GetLength(1); j++)
                {
                    if ((i+j)%2==0)
                    {
                        matrix4[i, j] = '-';
                    }
                    else
                    {
                        matrix4[i, j] = 'O';
                    }
                    Console.Write($"{matrix4[i, j],3}");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}

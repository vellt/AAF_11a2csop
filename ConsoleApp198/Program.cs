using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp198
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("versenyzők száma: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[N, 5];
            //[20,50]
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(20,51); //[20,50]
                }
            }

            //a
            int szamlalo = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool megfelelo = false;
                for (int j = 0; j < matrix.GetLength(1) && megfelelo==false; j++)
                {
                    int reszido = matrix[i, j];
                    if (reszido==30)
                    {
                        megfelelo = true;
                    }
                }
                if (megfelelo)
                {
                    szamlalo++;
                }
            }
            Console.WriteLine(szamlalo);

            //b
            bool van = false;
            for (int i = 0; i < matrix.GetLength(0) && van==false; i++)
            {
                bool megfelelo = true;
                for (int j = 0; j < matrix.GetLength(1)-1 && megfelelo==true; j++)
                {
                    int aktReszido = matrix[i, j];
                    int kovetkezoReszido = matrix[i, j + 1];
                    if (aktReszido<kovetkezoReszido)
                    {
                        megfelelo = false;
                    }
                }
                if (megfelelo)
                {
                    van = true;
                }
            }
            Console.WriteLine(van?"van":"nincs");

            //c
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int osszReszido = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    osszReszido += matrix[i, j];
                }
                Console.WriteLine($"{i+1}. versenyő összideje: {osszReszido}");
            }


            Console.ReadKey();
        }
    }
}

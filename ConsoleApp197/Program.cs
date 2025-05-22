using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp197
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[20, 4];
            Random r = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(0,101); // [0,100]
                }
            }

            int db = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                bool megfelel = true;
                for (int j = 0; j < matrix.GetLength(1) && megfelel==true; j++)
                {
                    int tantargy = matrix[i, j];
                    if (tantargy<60)
                    {
                        megfelel = false;
                    }
                }
                if (megfelel==true)
                {
                    db++;
                }
            }
            Console.WriteLine(db);

           
            List<double> atlagok = new List<double>(); // 0 elemű

            for (int j = 0; j < matrix.GetLength(1); j++) // 4
            {
                int osszSzazalek = 0;
                for (int i = 0; i < matrix.GetLength(0); i++) // 20
                {
                    osszSzazalek += matrix[i, j];
                }
                double tantargyAtlag = (double)osszSzazalek / matrix.GetLength(0);

                atlagok.Add(tantargyAtlag);
            }

            // legrosszabb tantargy
            int minIndex = 0;
            for (int i = 1; i < atlagok.Count(); i++)
            {
                if (atlagok[i]<atlagok[minIndex])
                {
                    minIndex = i;
                }
            }
            Console.WriteLine($"{minIndex+1}. tantárgy a legnehezebb");

            // c
            bool van = false;

            for (int i = 0; i < matrix.GetLength(0) && van==false; i++)
            {
                int szamlalo = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int tantargy = matrix[i, j];
                    if (tantargy>90)
                    {
                        szamlalo++;
                    }
                }
                if (szamlalo==matrix.GetLength(1)) //4
                {
                    van = true;
                }
            }
            Console.WriteLine(van?"igen":"nem");
            Console.ReadKey();
        }
    }
}

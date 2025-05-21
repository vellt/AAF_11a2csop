using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp187
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[30, 24];
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(-5,16);//[-5,15]
                }
            }
            //a
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine($"{i+1}. nap hőmérsékletei: ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            // b
            int ossz = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                ossz += matrix[14, i];
            }
            double atlag = (double)ossz / matrix.GetLength(1);
            Console.WriteLine($"a 15. nap átlaghőm: {Math.Round(atlag,1)}");

            //c
            bool van = false;

            for (int i = 0; i < matrix.GetLength(0) && van==false; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1 && van==false; j++)
                {
                    int aktualis = matrix[i, j];
                    int kovetkezo = matrix[i, j + 1];
                    if (aktualis+10 <= kovetkezo || aktualis-10 >= kovetkezo)
                    {
                        van = true;

                    }
                }
            }

            if (van)
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nincs");
            }

            // d
            
            int osszHom = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    osszHom += matrix[i, j];
                }
            }
            double honapAtlag = (double)osszHom / (matrix.GetLength(0) * matrix.GetLength(1));

            bool van2 = false;
            for (int i = 0; i < matrix.GetLength(0) && van2==false; i++)
            {
                int napiOsszHom = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    napiOsszHom += matrix[i, j];
                }
                double napiAtlag = (double)napiOsszHom / matrix.GetLength(1);
                if (napiAtlag< honapAtlag)
                {
                    van2 = true;
                }
            }

            // e
            bool van3 = false;
            for (int i = 0; i < matrix.GetLength(0) && van3==false; i++)
            {
                bool megfeleloNap = true;
                for (int j = 0; j < matrix.GetLength(1) && megfeleloNap==true; j++)
                {
                    if (matrix[i,j]!=0)
                    {
                        megfeleloNap = false;
                    }
                }
                if (megfeleloNap)
                {
                    van3 = true;
                }
            }
            Console.WriteLine(van3?"van":"nincs");

            //f
            int ossz12oraHom = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                ossz12oraHom += matrix[i, 11];
            }
            double atlagDeliHom = (double)ossz12oraHom / matrix.GetLength(0);
            Console.WriteLine(Math.Round(atlagDeliHom, 1));

            //g
            int elsoNapHom = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                elsoNapHom += matrix[0, i];
            }
            double elsoNapAtlag = (double)elsoNapHom / matrix.GetLength(1);

            int utolsoNapHom = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                utolsoNapHom += matrix[29, i];
                //utolsoNapHom += matrix[matrix.GetLength(0)-1, i];
            }
            double utolsoNapAtlag = (double)utolsoNapHom / matrix.GetLength(1);

            if (elsoNapHom> utolsoNapAtlag)
            {
                Console.WriteLine("Hónap elején volt melegebb");
            }
            else if(elsoNapAtlag==utolsoNapAtlag)
            {
                Console.WriteLine("Egyforma volt a hőm.");
            }
            else
            {
                Console.WriteLine("Hónap végén volt melegebb");
            }
            Console.ReadKey();
        }
    }
}

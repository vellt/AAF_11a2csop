using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static string Dupla(string szoveg)
        {
            string ujSzoveg = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char kar = szoveg[i];
                ujSzoveg += kar;
                ujSzoveg += kar;
            }
            return ujSzoveg;
        }

        static string IBetus(string szoveg)
        {
            string ujSzoveg = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                char kar = szoveg[i];
                if (kar == 97 || kar == 65 || kar == 101 || kar == 69 || kar == 105 ||
                    kar == 73 || kar == 111 || kar == 79 || kar == 117 || kar == 85)
                {
                    ujSzoveg += 'i';
                }
                else
                {
                    ujSzoveg += kar;
                }
            }
            return ujSzoveg;
        }

        static string Webcim(string szoveg)
        {
            string verzio1 = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                if (szoveg[i]==32)
                {
                    verzio1 += '-';
                }
                else
                {
                    verzio1 += szoveg[i];
                }
            }

            string verzio2 = "";
            for (int i = 0; i < verzio1.Length; i++)
            {
                if (verzio1[i]>=65 && verzio1[i]<=90)
                {
                    verzio2 += (char)(verzio1[i] + 32);
                }
                else
                {
                    verzio2 += verzio1[i];
                }
            }
            return verzio2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Dupla("Algorithm"));
            Console.WriteLine(Webcim("Ez Egy Webcim"));
            Console.WriteLine(IBetus("Kerekpar"));
            Console.ReadKey();
        }
    }
}

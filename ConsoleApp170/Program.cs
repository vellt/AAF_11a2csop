using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp170
{
    enum Szamits
    {
        Felszin, Terfogat
    }

    
    class Program
    {
        static double Gomb(double r, Szamits szamits)
        {
            switch (szamits)
            {
                case Szamits.Felszin:
                    return 4 * Math.PI * Math.Pow(r, 2);
                case Szamits.Terfogat:
                    return 4 / 3.0 * Math.PI * Math.Pow(r, 3);
                default: return 0;
            }
        }

        static double Teglatest(double a, double b, double c, Szamits szamits)
        {
            switch (szamits)
            {
                case Szamits.Felszin:
                    return 2 * (a * b + a * c + b * c);
                case Szamits.Terfogat:
                    return a * b * c;
                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}

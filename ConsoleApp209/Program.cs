using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp209
{
    class Turautvonal
    {
        public string Kiindulopont { get; set; }
        public string Vegpont { get; set; }
        public double Hossz { get; set; }
        public int Emelkedes { get; set; }
        public int Lejtes { get; set; }
        public char Pecsetelohely { get; set; }

        public Turautvonal(string sor)
        {
            string[] adat = sor.Split(';');
            Kiindulopont = adat[0]; // hidegkúti major
            Vegpont = adat[1]; // letérés sztupához
            Hossz = Convert.ToDouble(adat[2]); // 1.45
            Emelkedes = Convert.ToInt32(adat[3]); // 153
            Lejtes = Convert.ToInt32(adat[4]); // 53
            Pecsetelohely = Convert.ToChar(adat[5]); //i/n
        }

        public bool HianyosNev()
        {
            return Pecsetelohely == 'i' && !Vegpont.Contains("pecsetelohely");
        }

        public int TenylegesEmelkedes()
        {
            return Emelkedes - Lejtes;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("kektura.csv");
            int tengerszintFeletti =Convert.ToInt32(adatok[0]);
            List<Turautvonal> turautvonalak = adatok.Skip(1).Select(x => new Turautvonal(x)).ToList();

            // 3. feladat
            Console.WriteLine($"1. feladat: {turautvonalak.Count()}");

            // 4. feladat
            double osszHossz = 0;
            foreach (Turautvonal turautvonal in turautvonalak)
            {
                osszHossz += turautvonal.Hossz;
            }

            // 5
            int minIndex = 0;
            for (int i = 1; i < turautvonalak.Count(); i++)
            {
                if (turautvonalak[minIndex].Hossz > turautvonalak[i].Hossz)
                {
                    minIndex = i;
                }
            }
            Console.WriteLine($"kezdete: {turautvonalak[minIndex].Kiindulopont}");
            Console.WriteLine($"vége: {turautvonalak[minIndex].Vegpont}");
            Console.WriteLine($"hossz: {turautvonalak[minIndex].Hossz}");

            // 6
            // pipa

            // 7
            bool van = false;
            foreach (Turautvonal turautvonal in turautvonalak)
            {
                if (turautvonal.HianyosNev())
                {
                    Console.WriteLine(turautvonal.Vegpont);
                    van = true;
                }
            }
            if (!van)
            {
                Console.WriteLine("Nincs hiányos állomásnév!");
            }

            // 8
            int maxIndex = 0;
            int maxMagassag = turautvonalak[0].TenylegesEmelkedes();
            int aktualisMagassag = turautvonalak[0].TenylegesEmelkedes();
            for (int i = 1; i < turautvonalak.Count(); i++)
            {
                aktualisMagassag += turautvonalak[i].TenylegesEmelkedes();
                if (maxMagassag<aktualisMagassag)
                {
                    maxMagassag = aktualisMagassag;
                    maxIndex = i;
                }
            }
            Console.WriteLine("8. feladat");
            Console.WriteLine(turautvonalak[maxIndex].Vegpont);
            Console.WriteLine(tengerszintFeletti + maxMagassag);

            // 9
            List<string> output = new List<string>();
            output.Add(tengerszintFeletti.ToString());
            foreach (Turautvonal t in turautvonalak)
            {
                if (t.HianyosNev())
                {
                    t.Vegpont += " pecsetelohely";
                }
                output.Add($"{t.Kiindulopont};{t.Vegpont};{t.Hossz};{t.Emelkedes};{t.Lejtes};{t.Pecsetelohely}");
            }

            File.WriteAllLines("kektura2.csv", output);

            Console.ReadKey();
        }
    }
}

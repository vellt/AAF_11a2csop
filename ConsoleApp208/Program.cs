using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp22
{
    class Turaszakasz
    {
        public string Kiindulopont { get; set; }
        public string Vegpont { get; set; }
        public double Hossz { get; set; }
        public int Emelkedes { get; set; }
        public int Lejtes { get; set; }
        public char PecsethelyAvegpont { get; set; }

        public Turaszakasz(string kekturas)
        {
            string[] feloszt = kekturas.Split(';');
            Kiindulopont = feloszt[0];
            Vegpont = feloszt[1];
            Hossz = Convert.ToDouble(feloszt[2]);
            Emelkedes = Convert.ToInt32(feloszt[3]);
            Lejtes = Convert.ToInt32(feloszt[4]);
            PecsethelyAvegpont = Convert.ToChar(feloszt[5]);
        }

        public bool HianyosNev()
        {
            return PecsethelyAvegpont == 'i' && !Vegpont.Contains("pecsetelohely");
        }

        public int TenylegesEmelkedes()
        {
            return Emelkedes - Lejtes;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("kektura.csv");
            int tengerszintFelettiMagassag = Convert.ToInt32(adatok[0]); // első adatra ügyelni
            List<Turaszakasz> turaszakaszok = adatok.Skip(1).Select(x => new Turaszakasz(x)).ToList();

            // 3
            Console.WriteLine($"3.feladat: Szakaszok száma: {turaszakaszok.Count}");

            // 4
            double teljeshossz = 0;
            foreach (Turaszakasz hossz in turaszakaszok)
            {
                teljeshossz += hossz.Hossz;
            }
            Console.WriteLine($"4.feladat: A türa teljes hossza: {teljeshossz}");

            // 5
            int minIndex = 0;
            for (int i = 1; i < turaszakaszok.Count(); i++)
            {
                if (turaszakaszok[minIndex].Hossz > turaszakaszok[i].Hossz)
                {
                    minIndex = i;
                }
            }
            Console.WriteLine("5.feladat: A legrövidebb szakasz adatai: ");
            Console.WriteLine($"Kezdete: {turaszakaszok[minIndex].Kiindulopont}");
            Console.WriteLine($"Vége: {turaszakaszok[minIndex].Vegpont}");
            Console.WriteLine($"Távolság: {turaszakaszok[minIndex].Hossz}");

            // 7
            Console.WriteLine("7.feladat: Hiányos nevű végpontok:");
            bool van = false;
            for (int i = 0; i < turaszakaszok.Count(); i++)
            {
                if (turaszakaszok[i].HianyosNev())
                {
                    Console.WriteLine($"{turaszakaszok[i].Vegpont}");
                    van = true;
                }
            }
            if (!van)
            {
                Console.WriteLine("Nincs hiányos állomásnév");
            }

            // 8
            int maxIndex = 0;
            int maxVegpontMagassag= turaszakaszok[0].TenylegesEmelkedes();
            int vegpontMagassag = turaszakaszok[0].TenylegesEmelkedes(); // az első ennyin állt meg
            for (int i = 1; i < turaszakaszok.Count(); i++)
            {
                vegpontMagassag += turaszakaszok[i].TenylegesEmelkedes();
                if (maxVegpontMagassag< vegpontMagassag)
                {
                    maxIndex = i;
                    maxVegpontMagassag = vegpontMagassag;
                }
            }
            Console.WriteLine("8.feladat: A túra legmagasabban fekvő végpontja: ");
            Console.WriteLine($"A végpont neve: {turaszakaszok[maxIndex].Vegpont}");
            Console.WriteLine($"az út magassága: { tengerszintFelettiMagassag + maxVegpontMagassag}");

            //9
            List<string> output = new List<string>();
            output.Add(tengerszintFelettiMagassag.ToString());

            foreach (var t in turaszakaszok)
            {
                if (!t.HianyosNev())
                {
                    t.Vegpont += " pecsetelohely";
                }
                string sor = $"{t.Kiindulopont};{t.Vegpont};{t.Hossz};{t.Emelkedes};{t.Lejtes};{t.PecsethelyAvegpont}";
                output.Add(sor);
            }
            File.WriteAllLines("kektura2.csv", output);

            Console.WriteLine("9. feladat: kektura2.csv fájl elkészült.");

            Console.ReadKey();

        }
    }

}

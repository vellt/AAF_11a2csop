using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp200
{
    class Adat
    {
        // properties
        public int Helyezes { get; set; }
        public int SportolokSzama { get; set; }
        public string SportagNeve { get; set; }
        public string VersenyszamNeve { get; set; }
        // constructor
        public Adat(string adatsor)
        {
            string[] temp = adatsor.Split(' ');
            Helyezes = Convert.ToInt32(temp[0]);
            SportolokSzama = Convert.ToInt32(temp[1]);
            SportagNeve = temp[2];
            VersenyszamNeve = temp[3];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 2
            List<Adat> adatok = File.ReadAllLines("helsinki.txt")
                .Select(x => new Adat(x)).ToList();

            // 3
            Console.WriteLine(adatok.Count());

            // 4
            int a = 0, e = 0, b = 0;
            foreach (Adat adat in adatok)
            {
                if (adat.Helyezes == 1) a++; // arany
                if (adat.Helyezes == 2) e++; // ezüst
                if (adat.Helyezes == 3) b++; // bronz
            }
            Console.WriteLine($"arany: {a}");
            Console.WriteLine($"ezüst: {e}");
            Console.WriteLine($"bronz: {b}");

            // 5
            int osszes = 0;
            foreach (Adat adat in adatok)
            {
                int pont = 0;
                switch (adat.Helyezes)
                {
                    case 1: pont = 7; break;
                    case 2: pont = 5; break;
                    case 3: pont = 4; break;
                    case 4: pont = 3; break;
                    case 5: pont = 2; break;
                    case 6: pont = 1; break;
                }
                osszes += pont;
            }
            Console.WriteLine(osszes);

            // 6
            int torna = 0, uszas = 0;
            foreach (Adat adat in adatok)
            {
                if (adat.SportagNeve == "torna" && adat.Helyezes >= 1 && adat.Helyezes <= 3) 
                {
                    torna++;
                }
                if (adat.SportagNeve == "úszás" && adat.Helyezes >= 1 && adat.Helyezes <= 3)
                {
                    uszas++;
                }
            }
            if (uszas > torna) Console.WriteLine("uszas tobb");
            else if (uszas < torna) Console.WriteLine("torna tobb");
            else Console.WriteLine("döntetlen");

            // 7
            foreach (Adat adat in adatok)
            {
                if (adat.SportagNeve == "kajakkenu")
                {
                    adat.SportagNeve = "kajak-kenu";
                }
            }
            List<string> sorok = new List<string>();
            foreach (Adat adat in adatok)
            {
                int pont = 0;
                switch (adat.Helyezes)
                {
                    case 1: pont = 7; break;
                    case 2: pont = 5; break;
                    case 3: pont = 4; break;
                    case 4: pont = 3; break;
                    case 5: pont = 2; break;
                    case 6: pont = 1; break;
                }
                sorok.Add($"{adat.Helyezes} {adat.SportolokSzama} {pont} {adat.SportagNeve} {adat.VersenyszamNeve}");
            }
            File.WriteAllLines("helsinki2.txt", sorok);

            // 8
            int maxIndex = 0;
            for (int i = 0; i < adatok.Count(); i++)
            {
                if (adatok[i].SportolokSzama > adatok[maxIndex].SportolokSzama)
                {
                    maxIndex = i;
                }
            }
            Adat feladat8 = adatok[maxIndex];
            Console.WriteLine($"helyezés: {feladat8.Helyezes}");
            Console.WriteLine($"Sportág: {feladat8.SportagNeve}");
            Console.WriteLine($"versenyszám: {feladat8.VersenyszamNeve}");
            Console.WriteLine($"sportolók száma: {feladat8.SportolokSzama}");
            Console.ReadKey();
        }
    }
}

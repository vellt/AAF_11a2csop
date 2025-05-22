using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp199
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nevek = new List<string>(); //0
            nevek.Add("Geza");
            nevek.Add("Béla");
            nevek.Add("Béla");
            nevek.Add("Cecil");
            nevek.Add("Árpád");

            Console.WriteLine($"lista hossza: {nevek.Count()}"); //5

            //van-e benne Árpád
            bool van = nevek.Contains("Árpád");
            Console.WriteLine(van ? "igen" : "nincs");

            // hanyadik indexen van Béla
            int index = nevek.IndexOf("Béla");//ha nincs Béla-->-1
            Console.WriteLine(index);

            // nevek kiírása foreach-el
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            for (int i = 0; i < nevek.Count(); i++)
            {
                Console.WriteLine(nevek[i]);
            }

            // ábécé szerint növekvőbe rendezni az elemeket
            nevek.Sort();
            Console.WriteLine();
            // nevek kiírása foreach-el
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            // ábécé szerint csökkenő sorrendbe tenni
            nevek.Reverse();
            Console.WriteLine();
            // nevek kiírása foreach-el
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            nevek.RemoveAt(0); // mit csinál?
            // eltávolítja az első elemet

            nevek.Remove("Béla"); // minden előfordulást töröl

            foreach (string nev in nevek.Distinct())
            {
                Console.WriteLine(nev);
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp181
{
    class Program
    {
        static void Main(string[] args)
        {
            // kérjük le az 'a' karakter ASCII kódját (int) vagy Convert.ToInt32()
            // a-->97
            char a = 'a';
            Console.WriteLine(a);//a
            Console.WriteLine((int)a);//97


            // gyártsunk kisbetűből nagybetűt
            // x, y, z --> X, Y, Z
            // kicsi--> nagy akkor -32
            char x = 'x';
            char y = 'y';
            char z = 'z';

            char X = (char)(x - 32);
            char Y = (char)(y - 32);
            char Z = (char)(z - 32);

            Console.WriteLine($"{x}, {y}, {z} --> {X}, {Y}, {Z}");

            // Írd ki "a-z"-ig a betűket, melléjük azok nagybetűs alakját
            // a->z 
            // plusz nagybetűs alakjukat
            // a (A), b (B), c (C)

            for (int i = 97; i < 123; i++)
            {
                Console.WriteLine($"{(char)i} ({(char)(i-32)})");
            }

            // bekerjuk a nevunket ekezet nelkul
            // majd alakítsuk nagybetusse, DE csak akkor amennyiben az adott karakter
            // kisbetűs!
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            // csak azt alakítsuk nagybetusse amik kisbetus karakterek
            string nevNagybetus = "";
            for (int i = 0; i < nev.Length; i++)
            {
                char karakter = nev[i];
                if (karakter>=97 && karakter<=122) // akk kisbetűs
                {
                    // alakítsuk nagybetűssé
                    nevNagybetus += (char)(karakter - 32);
                }
                else
                {
                    // ami nem kisbetűs,
                    nevNagybetus += karakter;
                }
            }

            Console.WriteLine($"A neved nagybetusen: {nevNagybetus}");

            // szöveg tartalmaz-e számot?
            string szoveg = "ABC123";
            bool van = false;
            for (int i = 0; i < szoveg.Length && van==false; i++)
            {
                char karakter = szoveg[i];
                if (karakter>=48 && karakter<=57) // ha szám a karakter, akkor van
                {
                    van = true;
                }
            }
            Console.WriteLine(van?"van szám":"nincs");

            // Erős a jelszavunk?
            // Akkor erős, ha legalább 6 karakter hosszú,
            // tartalmaz számot, kisbetűt, nagybetűt
            string jelszo = "abc123";
            bool vanSzam = false;
            bool vanKisbetu = false;
            bool vanNagybetu = false;
            bool joJelszoHossz = jelszo.Length >= 6;

            for (int i = 0; i < jelszo.Length; i++)
            {
                char karakter = jelszo[i];
                if (karakter>=48 && karakter<=57)
                {
                    vanSzam = true;
                }
                if (karakter>=97 && karakter<=122)
                {
                    vanKisbetu = true;
                }
                if (karakter >= 65 && karakter <= 90)
                {
                    vanNagybetu = true;
                }
            }

            if (joJelszoHossz==true && 
                vanSzam==true && 
                vanKisbetu==true && 
                vanNagybetu ==true
                )
            {
                Console.WriteLine("Erős jelszó");
            }
            else
            {
                Console.WriteLine("nem erős a jelszó");
            }

            // bekérünk egy szöveget, fordított sorrendben írjuk ki
            string sz = Console.ReadLine();
            string forditottSz = "";
            for (int i = sz.Length - 1; i >= 0; i--)
            {
                forditottSz += sz[i];
            }
            Console.WriteLine($"A bekért szöveg fordított alakja: {forditottSz}");

            // duplázzunk meg minden egyes karakter-t
            // pl
            // ababa--> aabbaabbaa
            string sz2 = "ababa";
            string duplaSz2 = "";
            for (int i = 0; i < sz2.Length; i++)
            {
                char karakter = sz2[i];
                duplaSz2 += karakter;
                duplaSz2 += karakter;
            }
            Console.WriteLine(duplaSz2);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp160
{
    class Caesar
    {
        static int k = 3;
        static int n = 26;
        public static string Encrypt(string szoveg)
        {
            string ujSzoveg = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                int index = szoveg[i] - 65;
                int c = (index + k) % n;
                ujSzoveg += (char)(c + 65);
            }
            return ujSzoveg;
        }

        public static string Decrypt( string szoveg)
        {
            string ujSzoveg = "";
            for (int i = 0; i < szoveg.Length; i++)
            {
                int index = szoveg[i] - 65;
                int c = (n + index - k) % n;
                ujSzoveg += (char)(c + 65);
            }
            return ujSzoveg;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Caesar.Encrypt("ALMA"));
            Console.WriteLine(Caesar.Decrypt("DOPD"));
            Console.ReadKey();
        }
    }
}

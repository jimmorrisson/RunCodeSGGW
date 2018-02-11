using System;

namespace Zadanie10
{
    class Program
    {
        static string DodajLiterkiNaTekst(char a, char b, char c)
        {
            string napis = a + " " + b + " " + c;
            return napis;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DodajLiterkiNaTekst('a','l','a'));
            Console.ReadKey();
        }
    }
}

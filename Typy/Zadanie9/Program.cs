using System;

namespace Zadanie9
{
    class Program
    {
        static uint DodajLiterki(char a, char b)
        {
            return (uint)a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DodajLiterki('a','a'));
            Console.ReadKey();
        }
    }
}

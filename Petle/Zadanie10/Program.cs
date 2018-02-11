using System;

namespace Zadanie10
{
    class Program
    {
        static ulong Silnia(uint n)
        {
            ulong a = 1;
            while (n > 0)
            {
                a *= n;
                n--;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Silnia(0));
            Console.ReadKey();
        }
    }
}

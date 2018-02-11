using System;

namespace Zadanie1
{
    class Program
    {
        static ulong Silnia(uint n)
        {
            if(n==0)
            {
                return 1;
            }
            return n * Silnia(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Silnia(4));
            Console.ReadKey();
        }
    }
}

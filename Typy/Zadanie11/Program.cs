using System;

namespace Zadanie11
{
    class Program
    {
        static double ObliczSrednia(int a, int b)
        {
            return (double)(a + b) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ObliczSrednia(2, 4));
            Console.ReadKey();
        }
    }
}

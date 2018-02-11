using System;

namespace Zadanie7
{
    class Program
    {
        static double ObliczSrednia(int x, int y, int z)
        {
            var max = x;
            var min = x;
            if (y > max)
            {
                max = y;
            }
            if (z > max)
            {
                max = z;
            }
            if (y < min)
            {
                min = y;
            }
            if (z < min)
            {
                min = z;
            }
            return ((double)max + min) / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ObliczSrednia(1, 2, 4));
            Console.ReadKey();
        }
    }
}

using System;

namespace Zadanie4
{
    class Program
    {
        static uint IlePierwiastkow(double a, double b, double c)
        {
            var delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                return 2;
            }
            else if (delta == 0)
            {
                return 1;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IlePierwiastkow(2, 4, 2));
            Console.ReadKey();
        }
    }
}

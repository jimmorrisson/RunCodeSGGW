using System;

namespace Zadanie6
{
    class Program
    {
        static int ZwrocMax(int a, int b, int c)
        {
            var max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocMax(1, 1, 1));
            Console.ReadKey();
        }
    }
}

using System;

namespace Zadanie5
{
    class Program
    {
        static double Funkcja1(int a, int b, int c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                if (a == 0 || c == 0)
                {
                    throw new Exception("Can't divide by zero");
                }
                return ((double)(a + 2 * b - 5 * c)) / (a * c);
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Funkcja1(21, 0, 2));
            Console.ReadKey();
        }
    }
}

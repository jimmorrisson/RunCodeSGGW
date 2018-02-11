using System;

namespace Zadanie5
{
    class Program
    {
        static double ElementMin(double[] T)
        {
            double min = T[0];
            for (int i = 0; i < T.Length; i++)
            {
                if (min > T[i])
                    min = T[i];
            }
            return min;
        }
        static void Main(string[] args)
        {
            double[] tab = { 1, 2, 3, 4, 5 };
            Console.WriteLine(ElementMin(tab));
            Console.ReadKey();
        }
    }
}

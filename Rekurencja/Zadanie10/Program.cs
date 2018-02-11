using System;

namespace Zadanie10
{
    class Program
    {
        static uint IleJedynek(uint n)
        {
            uint reszta = n % 2;
            if (n <= 0)
            {
                if (reszta == 0)
                    return 0;
                return 1;
            }
            if (n > 0)
            {
                if (reszta != 0)
                {
                    return 1 + IleJedynek(n / 2);
                }

            }
            return IleJedynek(n / 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IleJedynek(255));
            Console.ReadKey();
        }
    }
}

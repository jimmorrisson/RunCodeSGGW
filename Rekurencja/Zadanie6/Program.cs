using System;

namespace Zadanie6
{
    class Program
    {
        static string ZwrocNiepodzielne(uint n)
        {
            if (n <= 0)
            {
                return "";
            }
            if (!(n % 3 == 0 || n % 5 == 0))
            {
                if (ZwrocNiepodzielne(n - 1) != "")
                    return ZwrocNiepodzielne(n - 1) + " " + n.ToString();
                return ZwrocNiepodzielne(n - 1) + n.ToString();
            }
            return ZwrocNiepodzielne(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocNiepodzielne(7));
            Console.ReadKey();
        }
    }
}

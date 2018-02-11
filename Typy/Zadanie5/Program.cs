using System;

namespace Zadanie5
{
    class Program
    {
        static bool ZwrocIloczyn(bool a, bool b)
        {
            return a && b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocIloczyn(true, true));
            Console.ReadKey();
        }
    }
}

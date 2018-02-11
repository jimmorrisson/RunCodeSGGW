using System;

namespace Zadanie4
{
    class Program
    {
        static bool ZwrocPrzeciwne(bool a)
        {
            return !a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocPrzeciwne(true));
            Console.ReadKey();
        }
    }
}

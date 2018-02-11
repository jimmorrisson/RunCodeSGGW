using System;

namespace Zadanie1
{
    class Program
    {
        static bool CzyZero(int a)
        {
            if (a == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyZero(1));
            Console.ReadKey();
        }
    }
}

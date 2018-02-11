using System;

namespace Zadanie8
{
    class Program
    {
        static bool CzyNiemalejace(int a, int b, int c)
        {
            if (b >= a && c >= b)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyNiemalejace(1, 1, 1));
            Console.ReadKey();
            
        }
    }
}

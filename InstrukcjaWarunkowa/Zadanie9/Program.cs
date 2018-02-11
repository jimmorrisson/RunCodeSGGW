using System;

namespace Zadanie9
{
    class Program
    {
        static bool CzyMalaLitera(char a, char b, char c)
        {

            if (a - 'Z' > 0 || b - 'Z' > 0 || c - 'Z' > 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyMalaLitera('A', 'a', 'C'));
            Console.ReadKey();
        }
    }
}

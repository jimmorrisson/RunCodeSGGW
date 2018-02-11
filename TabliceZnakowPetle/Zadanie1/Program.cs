using System;

namespace Zadanie1
{
    class Program
    {
        static bool CzyIstnieje(string napis, char a)
        {
            for (int i = 0; i < napis.Length; i++)
            {
                if(napis[i] == a)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CzyIstnieje("blabla", 'e'));
            Console.ReadKey();
        }
    }
}

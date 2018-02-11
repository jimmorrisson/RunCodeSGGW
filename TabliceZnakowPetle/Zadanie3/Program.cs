using System;

namespace Zadanie3
{
    class Program
    {
        static uint IleWyrazow2(string napis)
        {
            uint ile = 0;
            bool wyraz = false;
            for (int i = 0; i < napis.Length; i++)
            {
                if((napis[i]<=90&&napis[i]>=65) || (napis[i]<=122 && napis[i]>=97))
                {
                    wyraz = true;
                }
                else
                {
                    if(wyraz)
                    {
                        ile += 1;
                        wyraz = false;
                    }
                }
            }
            if (wyraz)
                ile += 1;
            return ile;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IleWyrazow2("dasjkdas/daskdask]dasjkdasjk:dasjkdas "));
            Console.ReadKey();
        }
    }
}

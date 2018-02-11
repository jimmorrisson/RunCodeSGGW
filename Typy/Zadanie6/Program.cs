using System;

namespace Zadanie6
{
    class Program
    {
        static uint ZwrocLiczbe(uint setki, uint dziesiatki, uint jednosci)
        {
            return setki * 100 + dziesiatki * 10 + jednosci;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocLiczbe(3,7,2));
            Console.ReadKey();
        }
    }
}

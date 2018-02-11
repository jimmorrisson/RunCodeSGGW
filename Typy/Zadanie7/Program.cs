using System;

namespace Zadanie7
{
    class Program
    {
        static string ZwrocLiczbeJakoTekst(uint setki, uint dziesiatki, uint jednosci)
        {
            return (setki * 100 + dziesiatki * 10 + jednosci).ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZwrocLiczbeJakoTekst(3,7,2));
            Console.ReadKey();
        }
    }
}

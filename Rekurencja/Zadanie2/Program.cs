﻿using System;

namespace Zadanie2
{
    class Program
    {
        static uint Dodaj1(uint n)
        {
            if(n==0)
            {
                return 0;
            }
            return n + Dodaj1(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj1(5));
            Console.ReadKey();
        }
    }
}

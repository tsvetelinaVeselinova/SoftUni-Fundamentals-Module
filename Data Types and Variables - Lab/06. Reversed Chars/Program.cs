﻿using System;

namespace _06._Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            Console.Write($"{thirdSymbol} {secondSymbol} {firstSymbol}");

        }
    }
}

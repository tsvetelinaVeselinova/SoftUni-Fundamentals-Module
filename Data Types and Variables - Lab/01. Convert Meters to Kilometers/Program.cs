using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metres = double.Parse(Console.ReadLine());
            double kilometres = metres / 1000;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}

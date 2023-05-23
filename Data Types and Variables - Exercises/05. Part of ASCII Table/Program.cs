using System;

namespace _05._Part_of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int fisrtChar =int.Parse(Console.ReadLine());
         int secondChar = int.Parse(Console.ReadLine());

            for (int i = fisrtChar; i <= secondChar; i++)
            {
                Console.Write($"{(char)i} ");
            }

        }
    }
}

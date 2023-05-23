using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte n = byte.Parse(Console.ReadLine());
            ushort totalLitres = 0;

            for (int i = 1; i <= n; i++)
            {
                ushort litres = ushort.Parse(Console.ReadLine());
                if (totalLitres <= 255)
                {
                    totalLitres += litres;
                    if (totalLitres > 255)
                    {
                        Console.WriteLine("Insufficient capacity!");
                        totalLitres -= litres;
                        continue;
                    }

                }
                else 
                {
                    Console.WriteLine("Insufficient capacity!");

                }

            }
            Console.WriteLine(totalLitres);


        }
    }
}

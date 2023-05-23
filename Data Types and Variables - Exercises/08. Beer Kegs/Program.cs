using System;
using System.Collections.Generic;
using System.Drawing;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
     
            byte n = byte.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string biggesKeg = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                uint height = uint.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
       
                if(volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggesKeg = model;
                }
            }

            Console.WriteLine(biggesKeg);


        }
    }
}

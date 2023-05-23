using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace _10._Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int power = int.Parse(Console.ReadLine());
            int initialPower = power;
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetsCount = 0;

            while (power >= distance)
            {
                power -= distance;
                targetsCount++;

                double percent = initialPower * 0.5;
                if (percent == power && exhaustionFactor != 0)
                {
                    power /= exhaustionFactor;

                }
                
            }
            Console.WriteLine(power);
            Console.WriteLine(targetsCount);
        }
    }
}

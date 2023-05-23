using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
            int n = int.Parse(Console.ReadLine());
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            BigInteger bestSnowball = 0;

            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if(snowballValue > bestSnowball)
                {
                    bestSnowball = snowballValue;
                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;
                }

            }

             Console.WriteLine($"{bestSnow} : {bestTime} = {bestSnowball} ({bestQuality})");


        }
    }
}

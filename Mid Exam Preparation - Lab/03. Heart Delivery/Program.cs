using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string command = "";
            int cupidIndex = 0;

            while ((command = Console.ReadLine()) != "Love!")
            {
                string[] arguments = command.Split().ToArray();
                int jumpLength = int.Parse(arguments[1]);

                cupidIndex += jumpLength;
                if (cupidIndex >= neighborhood.Length)
                {
                    cupidIndex = 0;
                }
                
                if (neighborhood[cupidIndex] == 0)
                {
                    Console.WriteLine($"Place {cupidIndex} already had Valentine's day.");
                    continue;
                }

                neighborhood[cupidIndex] -= 2;

                if (neighborhood[cupidIndex] <= 0)
                {
                    if (neighborhood[cupidIndex] < 0)
                    {
                        neighborhood[cupidIndex] = 0;
                    }

                    Console.WriteLine($"Place {cupidIndex} has Valentine's day.");
                }

            }

            Console.WriteLine($"Cupid's last position was {cupidIndex}.");

            int celebrationCounter = 0;

            for (int i = 0; i < neighborhood.Length; i++)
            {
                if (neighborhood[i] == 0)
                {
                    celebrationCounter++;
                }

            }

            if (celebrationCounter == neighborhood.Length)
            {
                Console.WriteLine("Mission was successful.");
            }

            else
            {
                Console.WriteLine($"Cupid has failed {neighborhood.Length - celebrationCounter} places.");
            }
        }
    }
}

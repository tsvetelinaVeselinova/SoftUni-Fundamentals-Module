using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            List<int> drumsQuality = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> initialQuality = new List<int>();
            initialQuality.AddRange(drumsQuality);

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                for (int i = 0; i < drumsQuality.Count; i++)
                {
                    drumsQuality[i] -= hitPower;
                    double drumPrice = initialQuality[i] * 3;
                    if (drumsQuality[i] <= 0)
                    {
                        if ((budget - drumPrice) >= 0)
                        { 
                            budget -= drumPrice;
                            drumsQuality.RemoveAt(i);
                            drumsQuality.Insert(i, initialQuality[i]);
                        }
                        else
                        {
                            drumsQuality.RemoveAt(i);
                            initialQuality.RemoveAt(i);
                            i--;
                        }
                    }
                }

            }

            Console.WriteLine(String.Join(" ", drumsQuality));
            Console.WriteLine($"Gabsy has {budget:f2}lv.");
        }
    }
}

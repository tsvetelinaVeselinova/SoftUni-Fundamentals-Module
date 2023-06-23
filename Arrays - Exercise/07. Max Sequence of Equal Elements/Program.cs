using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longestSequence = 0;
            int bestElement = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int count = 1;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                        if (longestSequence <= count)
                        {
                            longestSequence = count;
                            bestElement = numbers[j];
                        }
                    }
                    else
                    {
                        break;

                    }
                }
            }

            for (int k = 1; k <= longestSequence; k++)
            {
                Console.Write($"{bestElement} ");
            }
           
        }
    }
}

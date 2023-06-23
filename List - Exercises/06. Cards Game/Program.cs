using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                int firstPlayerCard = firstDeck[0];
                int secondPlayerCard = secondDeck[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                    firstDeck.Add(secondPlayerCard);
                    firstDeck.Add(firstPlayerCard);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                    secondDeck.Add(firstPlayerCard);
                    secondDeck.Add(secondPlayerCard);
                }
                else
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }

            }

            if (firstDeck.Count > secondDeck.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
            else if (secondDeck.Count > firstDeck.Count)
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
            else
            {
                Console.WriteLine("No player wins! Sum: 0");
            }

        }
    }
}

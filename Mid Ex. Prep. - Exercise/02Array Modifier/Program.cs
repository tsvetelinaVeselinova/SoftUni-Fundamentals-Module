using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split().ToArray();

                if (tokens[0] == "swap")
                {
                    int indexOne = int.Parse(tokens[1]);
                    int indexTwo = int.Parse(tokens[2]);

                    int temp = numbers[indexOne];
                    numbers[indexOne] = numbers[indexTwo];
                    numbers[indexTwo] = temp;

                }

                else if (tokens[0] == "multiply")
                {
                    int indexOne = int.Parse(tokens[1]);
                    int indexTwo = int.Parse(tokens[2]);

                    int product = numbers[indexOne] * numbers[indexTwo];
                    numbers.RemoveAt(indexOne);
                    numbers.Insert(indexOne, product);
                }
                else if (tokens[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
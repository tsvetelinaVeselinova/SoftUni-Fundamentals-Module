using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _07._List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string line = "";
            List<string> commands = new List<string>();

            while ((line = Console.ReadLine()) != "end")
            {
                List<string> tokens = line.Split().ToList();
                commands.Add(tokens[0]);
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numbetToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numbetToInsert);
                        break;
                    case "Contains":
                        Console.WriteLine(CheckForNumber(numbers, tokens));
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        Console.WriteLine(FilterNumbers(numbers, tokens));
                        break;
                }

            }
            if(commands.Contains("Add") || commands.Contains("Remove") || commands.Contains("RemoveAt")
                || commands.Contains("Insert"))
            {
                Console.WriteLine(string.Join(" ", numbers));
            }

         
        }

         static string FilterNumbers(List<int> numbers, List<string> tokens)
        {
            List<int> rightNumbers = new List<int>();
            int numberToCompare = int.Parse(tokens[2]);
            switch (tokens[1])
            {
                case "<":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < numberToCompare)
                        {
                            rightNumbers.Add(numbers[i]);
                        }
                    }
                    break;
                case ">":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > numberToCompare)
                        {
                            rightNumbers.Add(numbers[i]);
                        }
                    }
                    break;
                case ">=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] >= numberToCompare)
                        {
                            rightNumbers.Add(numbers[i]);
                        }
                    }
                    break;
                case "<=":
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= numberToCompare)
                        {
                            rightNumbers.Add(numbers[i]);
                        }
                    }
                    break;
            }
            return string.Join(" ", rightNumbers);
        }

        static string CheckForNumber(List<int> numbers, List<string> tokens)
        {
            int numberToCheck = int.Parse(tokens[1]);
            if(numbers.Contains(numberToCheck))
            {
                return "Yes";
            }

            return "No such number";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            StringBuilder result = new StringBuilder();
            List<string> nonNumbers = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    nonNumbers.Add(input[i].ToString());
                }

            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            int startIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> substring = new List<string>(nonNumbers);

                substring = substring.Skip(startIndex).Take(takeList[i]).ToList();

                result.Append(string.Join("", substring));

                startIndex += takeList[i] + skipList[i];
            }

            Console.WriteLine(result.ToString());
        }
    }
}
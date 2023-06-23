using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            string text = Console.ReadLine();
            List<char> textChars = new List<char>();
            textChars.AddRange(text);
            string result = "";

            for (int i = 0; i < numbers.Count; i++)
            {
                string substring = numbers[i];
                char[] substringNumbers = substring.ToCharArray();
                int sum = 0;
                for (int j = 0; j < substringNumbers.Length; j++)
                {
                    int number = int.Parse(substringNumbers[j].ToString());
                    sum += number;
                }

                int index = 0;

                if (sum < text.Length)
                {
                    index = sum;
                }
                else
                {
                    index = Math.Abs(text.Length - sum);
                }

                result += textChars[index];
                textChars.RemoveAt(index);
            }

            Console.WriteLine(result);
        }
    }
}

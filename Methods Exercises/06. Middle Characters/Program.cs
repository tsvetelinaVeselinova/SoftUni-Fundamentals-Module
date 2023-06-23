using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int inputLength = input.Length;
            
            if (IsEven(input.Length))
            {
                Console.WriteLine(MiddleCharEvenLength(input));
            }

            else if (IsOdd(inputLength))
            {
                Console.WriteLine(MiddleCharOddLength(input));
            }
        }

        static bool IsOdd(int inputLength)
        {
            if (inputLength % 2 != 0)
            {
                return true;
            }

            return false;
        }

        static bool IsEven(int inputLength)
        {
            if (inputLength % 2 == 0)
            {
                return true;
            }
            return false;
        }


        static string MiddleCharEvenLength(string input)
        {
            input.Split();
            int firstMiddleIndex = (input.Length / 2) - 1;
            int secondMiddleIndex = input.Length / 2;
            return $"{input[firstMiddleIndex]}{input[secondMiddleIndex]}";
        }

        static char MiddleCharOddLength(string input)
        {
            input.Split();
            int middleIndex = input.Length / 2;
            return input[middleIndex];
        }
    }
}

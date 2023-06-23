using System;
using System.Linq;
using System.Security.Cryptography;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(input));
        }

        static int GetMultipleOfEvenAndOdds(int input)
        {
            int product = 1;
            product = GetSumOfEvenDigits(input) * GetSumOfOddDigits(input);
            return product;
        }

        static int GetSumOfOddDigits(int input)
        {
            int sum = 0;
            int digit = 0;
            while (input > 0)
            {
                digit = input % 10;
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                input /= 10;
            }
            
            return sum;
        }

        static int GetSumOfEvenDigits(int input)
        {
            int sum = 0;
            int digit = 0;
            while (input > 0)
            {
                digit = input % 10;
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                input /= 10;
            }

            return sum;
        }
    }
}

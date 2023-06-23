using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

       static bool IsTopNumber(int i)
        {
            return (IsSumOfDigitsDivisibleByEight(i) && HasAnOddDigit(i));
        }

        static bool HasAnOddDigit(int i)
        {
            int digit = 0; 

            while (i > 0)
            {
                digit = i % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                i /=  10;
            }

            return false;

        }

        static bool IsSumOfDigitsDivisibleByEight(int i)
        {
            int digit = 0;
            int sum = 0;
            while (i > 0)
            {
                digit = i % 10;
                sum += digit;
                i /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}

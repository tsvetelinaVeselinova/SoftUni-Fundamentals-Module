using System;
using System.Threading;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(TheSmallestNumbers(firstNumber, secondNumber, thirdNumber));
        }

        static int TheSmallestNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smallestNumber = 0;
            if (firstNumber <= secondNumber && firstNumber <= thirdNumber)
            {
                smallestNumber = firstNumber;
            }
            else if (secondNumber <= firstNumber && secondNumber <= thirdNumber)
            {
                smallestNumber = secondNumber;
            }
            else if (thirdNumber <= firstNumber && thirdNumber <= secondNumber)
            {
                smallestNumber = thirdNumber;
            }

            return smallestNumber;
        }
    }
}

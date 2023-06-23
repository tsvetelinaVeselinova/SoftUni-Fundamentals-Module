using System;
using System.Collections.Generic;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Result(firstNumber,secondNumber,thirdNumber));

        }

        static int Result(int firstNumber, int secondNumber, int thirdNumber)
        {
            return SumOfFirstTwoIntegers(firstNumber, secondNumber) - thirdNumber;
        }

        static int SumOfFirstTwoIntegers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}

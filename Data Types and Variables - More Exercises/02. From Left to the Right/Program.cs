using System;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNums = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOfNums; i++)
            {
                string currentNum = Console.ReadLine();

                string[] currentNumbers = currentNum.Split(" ");
                long leftNumber = long.Parse(currentNumbers[0]);
                long rightNumber = long.Parse(currentNumbers[1]);
                long leftSum = 0;
                long rightSum = 0;

                if (leftNumber > rightNumber)
                {
                    while (leftNumber != 0)
                    {
                        leftSum += (int)(leftNumber % 10);
                        leftNumber /= 10;
                    }

                    Console.WriteLine(Math.Abs(leftSum));
                }
                else
                {
                    while (rightNumber != 0)
                    {
                        rightSum += (int)(rightNumber % 10);
                        rightNumber /= 10;
                    }

                    Console.WriteLine(Math.Abs(rightSum));
                }
            }
        }
    }
}



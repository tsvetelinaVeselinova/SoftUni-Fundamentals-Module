using System;
using System.Linq;
 
namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main()
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int[] bestSample = new int[dnaLength];
            int leftmostIndex = dnaLength;
            int bestLenght = 0;
            int bestSum = 0;
            int bestNumber = 1;
            int sampleNum = 0;
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] currentSample = command.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sampleNum++;

                int currentLenght = 0;
                int previousLenght = 0;
                int currentLongestSequence = 0;

                int currentleftmostIndex = dnaLength;

                int currentSum = 0;

                for (int i = 0; i < currentSample.Length; i++)
                {
                    if (currentSample[i] == 1)
                    {
                        currentLenght++;
                        currentSum++;
                    }
                    else
                    {
                        previousLenght = currentLenght;
                        currentLenght = 0;
                    }

                    if (currentLenght > previousLenght)
                    {
                        currentLongestSequence = currentLenght;
                        currentleftmostIndex = i - currentLenght + 1;
                    }
                }
                if (currentLongestSequence > bestLenght)
                {
                    bestLenght = currentLongestSequence;
                    leftmostIndex = currentleftmostIndex;
                    bestSample = currentSample;
                    bestNumber = sampleNum;
                    bestSum = currentSum;
                }
                else if (currentLongestSequence == bestLenght)
                {
                    if (currentleftmostIndex < leftmostIndex)
                    {
                        leftmostIndex = currentleftmostIndex;
                        bestSum = currentSum;
                        bestSample = currentSample;
                        bestNumber = sampleNum;
                    }
                    else if (leftmostIndex == currentleftmostIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            bestSample = currentSample;
                            bestNumber = sampleNum;
                        }
                    }
                }
                
            }

            Console.WriteLine($"Best DNA sample {bestNumber} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestSample));
        }
    }
}
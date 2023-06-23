using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{

    public static void Main(string[] args)
    {

        List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> resultNumbers = new List<int>();
        int shorterListCount = 0;
        int borderElementOne = 0;
        int borderElementTwo = 0;

        if (firstNumbers.Count > secondNumbers.Count)
        {
            shorterListCount = secondNumbers.Count;
            borderElementOne = firstNumbers[firstNumbers.Count - 2];
            borderElementTwo = firstNumbers[firstNumbers.Count - 1];

        }
        else
        {
            shorterListCount = firstNumbers.Count;
            borderElementOne = secondNumbers[0];
            borderElementTwo = secondNumbers[1];
            secondNumbers.RemoveAt(0);
            secondNumbers.RemoveAt(1);
        }

        secondNumbers.Reverse();

        for (int i = 0; i < shorterListCount; i++)
        {
            resultNumbers.Add(firstNumbers[i]);
            resultNumbers.Add(secondNumbers[i]);
        }

        if (borderElementOne > borderElementTwo)
        {
            int temp = borderElementOne;
            borderElementOne = borderElementTwo;
            borderElementTwo = temp;
        }

        List<int> orderedResult = new List<int>();

        if (borderElementOne == borderElementTwo)
        {
            for (int i = 0; i < resultNumbers.Count; i++)
            {
                if (resultNumbers[i] == borderElementOne)
                {
                    orderedResult.Add(resultNumbers[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < resultNumbers.Count; i++)
            {
                if (resultNumbers[i] > borderElementOne && resultNumbers[i] < borderElementTwo)
                {
                    orderedResult.Add(resultNumbers[i]);
                }
            }
        }

        orderedResult.Sort();
        Console.WriteLine(string.Join(" ", orderedResult));

    }
}



﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            float leftTime = 0;
            float rightTime = 0;
            int middleIndex = numbers.Count / 2;
            for (int i = 0; i < middleIndex; ++i)
            {
                leftTime += numbers[i];
                if (numbers[i] == 0)
                {
                    leftTime *= 0.8f;
                }
            }

            for (int i = numbers.Count - 1; i > middleIndex; --i)
            {
                rightTime += numbers[i];
                if (numbers[i] == 0)
                {
                    rightTime *= 0.8f;
                }
            }

            if (leftTime < rightTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            }
        }
    }
}

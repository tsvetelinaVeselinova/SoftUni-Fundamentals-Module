using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int listLength = numbers.Count;

            if (listLength % 2 == 0)
            {
                for (int i = 0; i < listLength / 2; i++)
                {
                    if (i == listLength / 2)
                    {
                        int sum = numbers[i] + 0;
                        result.Add(sum);
                    }
                    else
                    {
                        int sum = numbers[i] + numbers[numbers.Count - i - 1];
                        result.Add(sum);
                    }
                }

            }
            else
            {
                for (int i = 0; i <= listLength / 2; i++)
                {
                    if (i == listLength / 2)
                    {
                        int sum = numbers[i] + 0;
                        result.Add(sum);
                    }
                    else
                    {
                        int sum = numbers[i] + numbers[numbers.Count - i - 1];
                        result.Add(sum);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}

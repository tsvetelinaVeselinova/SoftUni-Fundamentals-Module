using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool noSuchElement = true;
            for (int i = 0; i < arr.Length; i++)
            {
                var leftsum = arr[..i].Sum();
                var rightSum = arr[(i + 1)..].Sum();
                if (leftsum == rightSum)
                {
                    noSuchElement = false;
                    Console.WriteLine(i);
                }
                
            }

            if (noSuchElement)
            {
                Console.WriteLine("no");
            }
        }
    }
}

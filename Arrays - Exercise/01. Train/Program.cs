using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] arr = new int[wagonsCount];
            int total = 0;

            for (int i = 0; i < wagonsCount; i++)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                arr[i] = peopleCount;
                total += peopleCount;
            }

            Console.WriteLine(string.Join(" ",arr));
            Console.WriteLine(total);
        }
    }
}

using System;
using System.Linq;
using System.Xml.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool istopInteger = false;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] > arr[j])
                    {
                        istopInteger = true;
                    }
                    else
                    {
                        istopInteger = false;
                        break;
                    }
                }

                if (istopInteger)
                {
                    Console.Write(arr[i] + " ");
                }

                istopInteger = false;
            }

                Console.Write(arr[arr.Length - 1]);

        }
    }
}
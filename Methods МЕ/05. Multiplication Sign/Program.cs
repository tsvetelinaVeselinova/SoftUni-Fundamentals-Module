using System;
using System.Threading.Channels;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse((Console.ReadLine()));
            int num2 = int.Parse((Console.ReadLine()));
            int num3 = int.Parse((Console.ReadLine()));

            Console.WriteLine(PositiveNegativeOrZero(num1, num2, num3));

        }

        static string PositiveNegativeOrZero(int num1, int num2, int num3)
        {
            int[] arr = new int[3];
            arr[0] = num1;
            arr[1] = num2;
            arr[2] = num3;
            string result = "";
            int counterPositive = 0;
            int counterNegative = 0;
            bool IsZero = false;

            for (int i = 0; i < arr.Length; i++)

            {
                if (arr[i] == 0)
                {
                    IsZero = true;
                    break;
                }
                else if (arr[i] > 0)
                {
                    counterPositive++;
                }
                else if (arr[i] < 0)
                {
                    counterNegative++;
                }
            }

            if (IsZero)
            {
                result = "zero";
            }
            else if (counterPositive == 3 || counterNegative == 2)
            {
                result = "positive";
            }
            else
            {
                result = "negative";
            }

            return result;
        }
    }
}


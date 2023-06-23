using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] tribonacciSequence = new int[num];
            string result = "";

            if (AreMoreThanThree(num))
            {
                Console.WriteLine(FindElementsFromFourthToLast(tribonacciSequence, result));
                
            }
            else
            {
                Console.WriteLine(FindElementsFromZeroToLast(num,tribonacciSequence));
            }

        }
        
        static bool AreMoreThanThree(int num)
        {
            if (num > 2)
            {
                return true;
            }

            return false;
        }
        static string FindElementsFromZeroToLast(int num,int[] tribonacciSequence)
        {
            string result = "";
            if (num == 1)
            {
                result = "1";
            }
            else if (num == 2)
            {
                result = "1 1";
            }
            else if (num == 3)
            {
                result = "1 1 2";
            }
            return result;
        }
        static string FindElementsFromFourthToLast(int[] tribonacciSequence, string result)
        {
            tribonacciSequence[0] = 1;
            tribonacciSequence[1] = 1;
            tribonacciSequence[2] = 2;
            result = $"{tribonacciSequence[0]} {tribonacciSequence[1]} {tribonacciSequence[2]} ";

            for (int i = 3; i < tribonacciSequence.Length; i++)
            {
                int sumPreviousThree = 0;
                sumPreviousThree = (tribonacciSequence[i - 3] + tribonacciSequence[i - 2] +
                                    tribonacciSequence[i - 1]);
                tribonacciSequence[i] = sumPreviousThree;
                result += $"{sumPreviousThree} ";
            }

            return result;
        }


    }
}
    


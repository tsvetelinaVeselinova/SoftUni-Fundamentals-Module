using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Console.WriteLine(NumberOfVowels(input));
        }

        static int NumberOfVowels(string input)
        {
            char[] array = input.ToCharArray();
            int vowelsCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'A' || array[i] == 'a' || array[i] == 'E' || array[i] == 'e' || array[i] == 'I'
                    || array[i] == 'i' || array[i] == 'O' || array[i] == 'o' || array[i] == 'U' || array[i] == 'u')
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}

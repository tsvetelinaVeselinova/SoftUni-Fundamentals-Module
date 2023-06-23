using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = String.Empty;

            while ((numbers = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrome(numbers).ToString().ToLower());
            }
        }

        private static bool IsPalindrome(string numbers)
        {
            string first = numbers.Substring(0, numbers.Length / 2);
            char[] array = numbers.ToCharArray();

            Array.Reverse(array);
            
            string temperory = new string(array);
            string second = temperory.Substring(0, temperory.Length / 2);

            return first == second;
        }
    }
}

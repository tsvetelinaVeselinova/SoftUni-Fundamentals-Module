using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            Console.WriteLine(AllCharactersBetweenThem(firstChar, secondChar));

        }

        static string AllCharactersBetweenThem(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                char temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }
            string characters = String.Empty;

            for (int i = firstChar + 1; i < secondChar; i++)
            {
                characters += $"{(char)i} ";
            }

            return characters;
        }
    }
}

using System;

namespace _05._Decrypting_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int newLetter = letter + key;
                Console.Write($"{(char)newLetter}");
            }

        }
    }
}

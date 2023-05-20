using System;
using System.Runtime.CompilerServices;

namespace _04.Rev._Str
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            string text = Console.ReadLine();
            string revesedText = String.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                revesedText += text[i];
            }

            Console.WriteLine(revesedText);
            
        }
    }
}

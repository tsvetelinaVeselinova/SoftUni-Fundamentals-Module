using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace _05.Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

              int n = int.Parse(Console.ReadLine());


              for (int i = 1; i <= n; i++)
            { 

                string num = Console.ReadLine();
                int length = num.Length;
                char mainSymbol = num[num.Length - 1];
                int mainDigit = mainSymbol - '0';
                int offset = (mainDigit - 2) * 3;
                
                 if (mainDigit == 8 || mainDigit == 9)
                  {
                    offset++;
                  }

                  int letterIndex = (offset + num.Length - 1);
                  int letter = letterIndex + 'a';
                  if(num == "0")
                   {
                    letter = 32;
                   }
                   

                  Console.Write((char)letter);

            }
        }
    }
}

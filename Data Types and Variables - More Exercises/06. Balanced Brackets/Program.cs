using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            int n = int.Parse(Console.ReadLine());
            int openingBrackets = 0;
            int closingBrackets = 0;
            bool areUnbalanced = false;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
               
                if(input == "(")
                {
                    openingBrackets++;
                    if(openingBrackets == 2 && closingBrackets == 0)
                    {
                        areUnbalanced = true;   
                    }

                }
                else if(input == ")")
                {
                   
                    closingBrackets++;
                    if (closingBrackets % 2 == 0 && openingBrackets % 2 != 0)
                    {
                        areUnbalanced = true;
                    }

                }
                
            }
            if(openingBrackets == closingBrackets && areUnbalanced == false)
            {
                Console.WriteLine("BALANCED");

            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}

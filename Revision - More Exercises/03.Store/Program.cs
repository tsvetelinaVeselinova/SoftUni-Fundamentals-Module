using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;

namespace _03.Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            double balance = double.Parse(Console.ReadLine());
            string gameName = string.Empty;
            double gamePrice = 0;
            double totalSpent = 0;

            while((gameName = Console.ReadLine()) != "Game Time")
            {
                
                if (gameName == "OutFall 4")
                {
                    gamePrice = 39.99;
                    if(gamePrice > balance)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                    balance -= gamePrice;
                    totalSpent += gamePrice;
                }
                else if (gameName == "CS: OG")
                {
                    gamePrice = 15.99;
                    if (gamePrice > balance)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                    balance -= gamePrice;
                    totalSpent += gamePrice;

                }
                else if (gameName == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                    if (gamePrice > balance)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                    balance -= gamePrice;
                    totalSpent += gamePrice;

                }
                else if (gameName == "Honored 2")
                {
                    gamePrice = 59.99;
                    if (gamePrice > balance)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                    balance -= gamePrice;
                    totalSpent += gamePrice;

                }
               
                else if (gameName == "RoverWatch")
                {
                    gamePrice = 29.99;
                    if (gamePrice > balance)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                    balance -= gamePrice;
                    totalSpent += gamePrice;

                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                    if (gamePrice > balance)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"Bought {gameName}");
                    }
                    balance -= gamePrice;
                    totalSpent += gamePrice;

                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                if(balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

            }
            if (gameName == "Game Time")
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}

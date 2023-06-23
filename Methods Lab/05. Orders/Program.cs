using System;
using System.Diagnostics;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {

           string productType = Console.ReadLine();
           int quantity = int.Parse(Console.ReadLine());

           Console.WriteLine($"{TotalPriceOfAnOrder(productType, quantity):f2}");
        }

        static double TotalPriceOfAnOrder(string productType, int quantity)
        {
            double price = 0;
            double totalPrice = 0;
            switch (productType)
            {
                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1.0;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2.0;
                    break;
            }

            totalPrice = price * quantity;
            return totalPrice;
        }
    }
}

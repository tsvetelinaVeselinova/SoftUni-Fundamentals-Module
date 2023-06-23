using System;

namespace _01.Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalPriceWithoutTaxes = 0;
            double taxes = 0;
            bool isSpecial = false; 

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "special" || input == "regular")
                {
                    if (input == "special")
                    {
                        isSpecial = true;
                    }
                    break;
                }

                double price = double.Parse(input);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }

                totalPriceWithoutTaxes += price;
                taxes += price * 0.2;
            }

            double totalPrice = totalPriceWithoutTaxes + taxes;
            

            if (isSpecial)
            {
                totalPrice *= 0.9;
            }

            if (totalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }

            if (totalPrice != 0)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
            
        }
    }
}

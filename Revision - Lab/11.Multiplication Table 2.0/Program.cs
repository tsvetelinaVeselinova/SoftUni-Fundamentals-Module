using System;

namespace _11.Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rewrite the program from the previous task so it can receive the multiplier from the console. Print the
            //table with the multiplier in the interval from the given number to 10.If the given multiplier is more than 10,
            //print only one row with the integer, the given multiplier, and the product.See the examples below for more
            //information.
            //Output
            //Print every row of the table in the following format:
            //{ theInteger} X { times} = { product}
            //Constraints
            //• The integer will be in the interval[1...100]


            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product = 1;

            if (multiplier > 10)
            {
                product = n * multiplier;
                Console.WriteLine($"{n} X {multiplier} = {product}");
                
            }
            for (int i = multiplier; i <= 10; i++)
            {

                product = n * i;
                Console.WriteLine($"{n} X {i} = {product}");
            }
        }
    }
}

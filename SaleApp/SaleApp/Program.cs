using System;

namespace SaleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare our variables
            double price, tax, total;

            //Assign values for each variabel
            price = 29.75;
            tax = 1.76;
            total = 31.51;

            //Print our totals.
            Console.WriteLine($"The price of the item is {price:C}");
            Console.WriteLine($"The tax is {tax:C}");
            Console.WriteLine($"The total is {total:C}");
        }
    }
}

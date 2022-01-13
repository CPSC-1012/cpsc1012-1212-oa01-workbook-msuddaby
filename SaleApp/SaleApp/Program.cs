using System;

namespace SaleApp
{


    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare our variables
            double price, tax, total;
            const double taxrate = 0.05;

            Console.Write("Enter price: ");
            string priceprompt = Console.ReadLine();
            price = double.Parse(priceprompt);

            //Assign values for each variable
            tax = price * taxrate;
            total = price + tax;

            //Print our totals.
            Console.WriteLine($"{"Price:", -10} {price, 8:C}");
            Console.WriteLine($"{"Tax:", -10} {tax, 8:C}");
            Console.WriteLine($"{"Total:", -10} {total, 8:C}");
        }
    }
}

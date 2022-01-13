using System;

namespace Wages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double regularWages, overtimeWages, totalwages;
            double overtimePay = 37.5;
            double overtimeHours = 10;

            Console.Write("Enter the base pay: ");
            double basePay = double.Parse(Console.ReadLine());
            Console.Write("Enter the regular hours: ");
            double regularHours = double.Parse(Console.ReadLine());

            regularWages = basePay * regularHours;
            overtimeWages = overtimePay * overtimeHours;
            totalwages = regularWages + overtimeWages;
            Console.WriteLine($"Total wages for this week are {totalwages:C}");

        }
    }
}

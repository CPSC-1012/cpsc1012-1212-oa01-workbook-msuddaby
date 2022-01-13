using System;

namespace SequenceStructure_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NextMonthInterest();
        }

        //Question 1, Part 1
        public static void NameSalary()
        {
            string name = "Matt";
            int age = 19;
            double annualPay = 55000000.5;

            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year.");
        }
        
        //Question 1, Part 2
        public static void NameSalaryInput()
        {
            string name;
            int age;
            double annualPay;

            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());
            Console.Write("What is your annual salary? ");
            annualPay = double.Parse(Console.ReadLine());

            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year.");
        }

        //Question 2
        public static void HexagonArea()
        {
            double side, area;

            Console.Write("Enter the length of the side: ");
            side = double.Parse(Console.ReadLine());

            area = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(side, 2);

            Console.WriteLine($"The area of the hexagon is: {Math.Round(area, 4)}");
        }


        //Question 3
        public static void DigitAdder()
        {
            //I would usually use an array in this situation to break the number down into digits, but we aren't at that point yet in the class.
            
            int num;

            Console.Write("Enter a number between 0 and 1000: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine((((num / 10) / 10) % 10) + ((num / 10) % 10) + (num % 10));
        }

        //Question 4
        public static void NextMonthInterest()
        {
            double amount, rate;
            int years;

            Console.Write("Enter investment amount: ");
            amount = double.Parse(Console.ReadLine());
            Console.Write("Emter annual interest rate %: ");
            rate = double.Parse(Console.ReadLine());
            Console.Write("Enter number of years: ");
            years = int.Parse(Console.ReadLine());

            double monthyInterestRate = (rate / 12) / 100;
            double futureInvestmentValue = amount * (Math.Pow((1 + monthyInterestRate), (years*12)));

            Console.WriteLine($"Future value is {futureInvestmentValue:C}");

        }

    }
}

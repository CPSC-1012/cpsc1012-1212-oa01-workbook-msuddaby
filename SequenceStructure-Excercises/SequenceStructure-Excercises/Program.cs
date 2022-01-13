using System;

namespace SequenceStructure_Excercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NextMonthInterest();
        }

        /* Question 1, Part 1
         *
         * Purpose: display a name, their age and the salary they hope to earn in the year.
         *  
         * Inputs: none.
         * Outputs: name, age, annualPay
         *
        */
        public static void NameSalary()
        {
            //Declare variables and their values.
            string name = "Matt";
            int age = 19;
            double annualPay = 55000000.5;

            //Output all of our variables into a readable sentence.
            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year.");
        }
        
        //Question 1, Part 2
        /*
         * Purpose: display a name, their age and the salary they hope to earn in the year.
         *  
         * Inputs: name, age, annualPay
         * Outputs: name, age, annualPay
         *
        */
        public static void NameSalaryInput()
        {
            //Initially declare our variables with no values.
            string name;
            int age;
            double annualPay;

            //Prompt the user for our values.
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());
            Console.Write("What is your annual salary? ");
            annualPay = double.Parse(Console.ReadLine());

            //Display a readable sentence with all of the user provided information.
            Console.WriteLine($"My name is {name}, my age is {age} and I hope to earn {annualPay:C} per year.");
        }

        //Question 2
        /*
         * Purpose: Caclulate the area of a hexagon using the length of one side.
         *  
         * Inputs: hexagon side length
         * Outputs: area
         *
        */
        public static void HexagonArea()
        {
            //Initally declare our variables with no values.
            double side, area;

            //Prompt the user for the length of one side of the hexagon.
            Console.Write("Enter the length of the side: ");
            side = double.Parse(Console.ReadLine());

            //Calculate the area of the hexagon using the user provided side length
            area = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(side, 2);

            //Output the final calculated area to the console.
            Console.WriteLine($"The area of the hexagon is: {Math.Round(area, 4)}");
        }


        //Question 3
        /*
         * Purpose: Take a user provided number (between 0 and 1000) then add each individual digit together.
         *  
         * Inputs: a number, between 0 and 1000
         * Outputs: the sum of each digit in the number. 
         *
         */
        public static void DigitAdder()
        {
            //I would usually use an array in this situation to break the number down into digits, but we aren't at that point yet in the class.
            //Initially declare our variable with no value.
            int num;

            //Prompt the user for any number between 0 and 1000
            Console.Write("Enter a number between 0 and 1000: ");
            num = int.Parse(Console.ReadLine());

            //Find each digit in the number, add it to the next digit and print the final sum of each digit to the console.
            Console.WriteLine((((num / 10) / 10) % 10) + ((num / 10) % 10) + (num % 10));
        }

        //Question 4
        /*
         * Purpose: Calculate the interest on the following month's payment using a formula.
         *  
         * Inputs: The amount invested, the annual interest rate in percentage form, the number of years 
         * Outputs: The interest on the next monthly payment.
         *
         */
        public static void NextMonthInterest()
        {
            //Initially declare our variables with no values.
            double amount, rate;
            int years;

            //Prompt the user for our investment amount, annual interest rate in percentage form and the number of years.
            Console.Write("Enter investment amount: ");
            amount = double.Parse(Console.ReadLine());
            Console.Write("Emter annual interest rate %: ");
            rate = double.Parse(Console.ReadLine());
            Console.Write("Enter number of years: ");
            years = int.Parse(Console.ReadLine());

            //Calculate the monthly interest rate from the yearly interest rate
            double monthyInterestRate = (rate / 12) / 100;
            //Use our formula to calculate the future investment value
            double futureInvestmentValue = amount * (Math.Pow((1 + monthyInterestRate), (years*12)));

            //Print the calculated amount to the console.
            Console.WriteLine($"Future value is {futureInvestmentValue:C}");

        }

    }
}

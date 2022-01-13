using System;

namespace ArithmeticProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitAdder();
        }

        /*
         * Question 1
         * 
         * Purpose: Given 3 real numbers, calculate the mean average of them all.
         * 
         * Input: 3 real numbers.
         * Output: The mean average of the 3 numbers
         * 
         */
        public static void MeanAverage()
        {
            //Initially declare our variables with no values
            double real1, real2, real3, mean;

            //Prompt the user for 3 real numbers
            Console.Write("Enter real number 1: ");
            real1 = double.Parse(Console.ReadLine());
            Console.Write("Enter real number 2: ");
            real2 = double.Parse(Console.ReadLine());
            Console.Write("Enter real number 3: ");
            real3 = double.Parse(Console.ReadLine());

            //Find the mean average of the 3 real numbers that the user provided.
            mean = (real1 + real2 + real3) / 3;

            //Print the calculated mean average of the 3 real numbers to the console.
            Console.WriteLine($"The mean average of the 3 numbers are: {mean}");
        }

        /*
         * Question 2
         * 
         * Purpose: Given 3 real numbers, calculate the mean average of them all. Round the answer by 2 decimal places.
         * 
         * Input: 3 real numbers.
         * Output: The mean average of the 3 numbers, rounded by 2 decimal places
         * 
         */
        public static void MeanAverageRounded()
        {
            //Initially declare our variables with no values
            double real1, real2, real3, mean;

            //Prompt the user for 3 real numbers
            Console.Write("Enter real number 1: ");
            real1 = double.Parse(Console.ReadLine());
            Console.Write("Enter real number 2: ");
            real2 = double.Parse(Console.ReadLine());
            Console.Write("Enter real number 3: ");
            real3 = double.Parse(Console.ReadLine());

            //Find the mean average of the 3 real numbers that the user provided.
            mean = (real1 + real2 + real3) / 3;

            //Print the calculated mean average of the 3 real numbers to the console. Round the total by 2 decimal points.
            Console.WriteLine($"The mean average of the 3 numbers are: {Math.Round(mean, 2)}");
        }

        /*
         * Question 3
         * 
         * Purpose: Using the Pythagorean Theorem, calculate the hypotenuse of a right triange given the height and base.
         * 
         * Input: height and base of a right angle triangle
         * Output: The lengh of the hypotenuse for the right angle triangle.
         * 
         */
        public static void HypotenuseLength()
        {
            //Initially declare our variables with no values.
            double height, tbase, length;

            //Promp the user for the height and base of the right angle triangle
            Console.Write("Provide the height of the right angle triangle: ");
            height = double.Parse(Console.ReadLine());
            Console.Write("Provide the base of the right angle triangle: ");
            tbase = double.Parse(Console.ReadLine());

            //Calculate the length of the hypotenuse using the formula
            height = Math.Pow(height, 2);
            tbase = Math.Pow(tbase, 2);
            length = Math.Sqrt(height + tbase);

            //Output the calculated length of the hypotenuse to the console.
            Console.WriteLine($"The lenth of your right angle triangle's hypotenuse is {length}");
        }

        //Question 4
        /*
         * Purpose: Take a user provided number (between 0 and 1000) then add each individual digit together. Display both the sum of the digits and the original number
         *  
         * Inputs: a number, between 0 and 1000
         * Outputs: the sum of each digit in the number, and the original number 
         *
         */
        public static void DigitAdder()
        {
            //Initially declare our variable with no value.
            int num;

            //Prompt the user for any 3 digit number
            Console.Write("Enter a 3 digit number: ");
            num = int.Parse(Console.ReadLine());

            //Find each digit in the number, add it to the next digit and print the final sum of each digit to the console.
            Console.WriteLine($"{num} -> sum = {(((num / 10) / 10) % 10) + ((num / 10) % 10) + (num % 10)}");
        }


    }
}

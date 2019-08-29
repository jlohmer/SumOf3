using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string firstNumberAsString;
            string secondNumberAsString;
            string thirdNumberAsString;
            string sentence;
            string sentence2;
            double firstNumber;
            double secondNumber;
            double thirdNumber;
            double sumOf3;
            const double multFactor = 7.777;
            double constTimesSum;

            //Prompt user for input
            Console.WriteLine("You will be prompted to enter 3 numbers one at a time. Decimals are allowed to 3 decimal places.");
            Console.WriteLine("After the 3 numbers are entered, they will be summed and then the sum will be multiplied by the constant value of 7.777");
            Console.WriteLine("Please enter your first number >>");
            firstNumberAsString = Console.ReadLine();

            Console.WriteLine("Please enter your second number >>");
            secondNumberAsString = Console.ReadLine();

            Console.WriteLine("Please enter your third number >>");
            thirdNumberAsString = Console.ReadLine();

            //Convert strings to number data types
            firstNumber = Convert.ToDouble(firstNumberAsString);
            secondNumber = Convert.ToDouble(secondNumberAsString);
            thirdNumber = Convert.ToDouble(thirdNumberAsString);

            //Sum the 3 user numbers
            sumOf3 = firstNumber + secondNumber + thirdNumber;

            //Outputting the sum of the 3 user inputted numbers
            sentence = "The sum of the 3 numbers you inputted is " + sumOf3.ToString();
            Console.WriteLine(sentence);

            //Multiplying the sum times the constant
            constTimesSum = multFactor * sumOf3;

            //Outputting the sum of the 3 user inputted numbers
            sentence2 = "The sum of your numbers multiplied by the constant of 7.777 is " + constTimesSum.ToString();
            Console.WriteLine(sentence2);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculatorApp_erik
{
    public class ImplementCalcMethods : ICalculator
    {
       

        public static double AddMethod(params double[] numbers)
        {

            double result = 0;
            foreach (double num in numbers)
            {
                result += num;
            }
            return result;
        }

        

        public static double DivisionMethod(params double[] numbers)
        {
            double result = 0;
            foreach (double num in numbers)
            {
                result /= num;
            }
            return result;
        }

        

        public static double ModulusMethod(params double[] numbers)
        {
            double result = 0;
            foreach (double num in numbers)
            {
                result %= num;
            }
            return result;
        }

        

        public static double MultiplicationMethod(params double[] numbers)
        {
            double result = 0;
            foreach (double num in numbers)
            {
                result *= num;
            }
            return result;
        }

        

        public static double SquareRootMethod(params double[] numbers)
        {
            double result = 0;
            foreach (double num in numbers)
            {
                result = Math.Sqrt(num);
            }
            return result;
        }

        

        public static double SubMethod(params double[] numbers)
        {
            double result = 0;
            foreach (double num in numbers)
            {
                result -= num;
            }
            return result;
        }
        public static double Calculator()
        {
            Console.WriteLine("Enter the numbers you would like to calculate (seperated by spaces):\n");
            var userInput = Console.ReadLine();
            string[] numbersInputed = userInput.Split(' ');
            double[] numbers = new double[numbersInputed.Length];

            for (double i = 0; i < numbersInputed.Length; i++)
            {
                if (double.TryParse(numbersInputed[i], out double num))
                {
                    numbers[i] = num;
                }
                else
                {
                    Console.WriteLine($"Invalid Input: {numbersInputed[i]} is not a valid");
                }
            }
            Console.WriteLine("What would you like to do? Enter the corresponding number to select your method of opration:\n1. Add\n2. Subtract\n3. Multiply\n4. Divide\n5. Find the square root\n6. Find the remainder");
            var userSelect = Console.ReadLine();
            switch(userSelect)
            {
                case 1:
                    AddMethod();
            }
            
        }

        
    }
}

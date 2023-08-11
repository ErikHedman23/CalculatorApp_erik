using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculatorApp_erik
{
    public class ImplementCalcMethods : ICalculator
    {
        public static double result = 0;

        public static double AddMethod(params double[] numbers)
        {

            result = 0;
            foreach (double num in numbers)
            {
                result += num;
            }
            return result;
        }



        public static double DivisionMethod(params double[] numbers)
        {
            result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers == null)
                {
                    return 0;
                }
                else
                {
                    result /= numbers[i];
                }
            }
            return result;
        }



        public static double ModulusMethod(params double[] numbers)
        {
            result = 0;
            foreach (double num in numbers)
            {
                result %= num;
            }
            return result;
        }



        public static double MultiplicationMethod(params double[] numbers)
        {
            result = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
            {
                if ()
            }
            result = 0;
            foreach (double num in numbers)
            {
                result *= num;
            }
            return result;
        }



        public static double SquareRootMethod(params double[] numbers)
        {
            result = 0;
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("Invalid entry: please input a number to run calculator correctly...");
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                result += Math.Sqrt(numbers[i]);

            }
            return result;


        }



        public static double SubMethod(params double[] numbers)
        {
            result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers == null)
                {
                    return 0;
                }
                else
                {
                    result -= numbers[i];
                }
            }
            return result;

        }
        public static void Calculator()
        {
            bool userSelect;
            result = 0;

            Console.WriteLine("Enter the numbers you would like to calculate (seperated by spaces):\n");
            var userInput = Console.ReadLine();
            string[] numbersInputed = userInput.Split(' ');
            double[] numbers = new double[numbersInputed.Length];
            do
            {

                for (int i = 0; i < numbersInputed.Length; i++)
                {
                    if (double.TryParse(numbersInputed[i], out double num))
                    {
                        numbers[i] = num;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid Input: {numbersInputed[i]} is not a valid");
                        continue;
                    }
                }
            } while (false);


            do
            {


                Console.WriteLine("Enter the corresponding number to select your method of opration:\n1. Add\n2. Subtract\n3. Multiply\n4. Divide\n5. Find the square root\n6. Find the remainder\n");
                userSelect = double.TryParse(Console.ReadLine(), out double userOutput);
                switch (userOutput)
                {
                    case 1:
                        result = AddMethod(numbers);
                        break;

                    case 2:
                        result = SubMethod(numbers);
                        break;

                    case 3:
                        result = MultiplicationMethod(numbers);
                        break;
                    case 4:
                        result = DivisionMethod(numbers);
                        break;
                    case 5:
                        result = ModulusMethod(numbers);
                        break;
                    case 6:
                        result = SquareRootMethod(numbers);
                        break;
                    default:
                        InvalidReturn();
                        continue;

                }
            } while (userSelect == false);
            Console.WriteLine($"Your result is: {result}");

        }
        public static void InvalidReturn()
        {
            Console.WriteLine("Invalid Entry, please select one of the following options.");

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CalculatorApp_erik
{
    public class ImplementCalcMethods : ICalculator
    {
        internal static double result = 0;

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



        //public static double ModulusMethod(params double[] numbers)
        //{
        //    var resultMod = new double[numbers.Length];
        //    bool userInput = true;
        //    do
        //    {
        //        foreach (double num in numbers)
        //        {
        //            Console.WriteLine($"By what number would you like to find the modulus of {num}?");
        //            userInput = double.TryParse(Console.ReadLine(), out double numToMod);
        //            if (!userInput)
        //            {
        //                Console.WriteLine("Invalid entry");
        //                continue;

        //            }
        //            else
        //            {
        //                resultMod[0] = num % numToMod;

        //            }
        //        }
        //        for (int i = 0; i < numbers.Length; i++)
        //        {

        //            Console.WriteLine($"The remainder of {numbers[i]} is {result[i]}");
        //        }
        //    } while (!userInput);

        //    return resultMod;
        //}



        public static double MultiplicationMethod(params double[] numbers)
        {
            result = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers == null || numbers.Length == 0)
                {
                    Console.WriteLine("Invalid entry: Please enter a number to access this method...");
                    return 0;
                }
                else
                {
                    result *= numbers[i];
                }
            }
            return result;

        }



        public static void SquareRootMethod()
        {
            double number = 0;
            result = number;
            bool userInput;
            do
            {
                Console.WriteLine("Enter a number to find the square root of it.  Enter only one number:");
                userInput = double.TryParse(Console.ReadLine(), out number);
                if (!userInput)
                {
                    Console.WriteLine("Invalid entry: please input a number to run calculator correctly...");
                    break;
                }
                else
                {
                result += Math.Sqrt(number);

                }



            } while (!userInput);


            Console.WriteLine($"The square root of {number} is: {result}");


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

        public static void UserSelect ()
        {
                int userOutput = 0;
            do
            {

                Console.WriteLine("Would you like to find the sqaure root of a given number? If yes, Enter 1, if no, Enter 2:");
                var uI = int.TryParse(Console.ReadLine(), out userOutput);
                switch (userOutput)
                {
                    case 1:
                        SquareRootMethod();
                        break;
                    case 2:
                        Calculator();
                        break;
                    default:
                        InvalidReturn();
                        break;
                }
            } while (userOutput < 1 || userOutput > 2);
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
                        Console.WriteLine();
                        Console.WriteLine($"Invalid Input: {numbersInputed[i]} is not a valid number...\n\n");
                        
                        continue;
                    }
                }
            } while (false);


            do
            {


                Console.WriteLine("Enter the corresponding number to select your method of operation:\n1. Add\n2. Subtract\n3. Multiply\n4. Divide\n");
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
                    //case 5:
                    //    result = SquareRootMethod(numbers);
                    //    break;
                    //case 6:
                    //    result = ModulusMethod(numbers);
                    //    break;
                    default:
                        InvalidReturn();
                        continue;

                }
            } while (userSelect == false);
            Console.WriteLine($"Your result is: {result}");

            
        }

        public static bool ContinueOrEnd()
        {
            bool userIn;
            do
            {

                Console.WriteLine("Would you like to perform more calculations?");
                Console.WriteLine("If yes, enter a 1; if you would like to exit the calculator, enter 2:");

                userIn = int.TryParse(Console.ReadLine(), out int userOut);

                if (userOut == 1)
                {
                    UserSelect();
                }
                else if (userOut == 2)
                {
                    Console.WriteLine("Thank you for calculating with me!");
                    Thread.Sleep(1000);
                    Console.Write(". ");
                    Thread.Sleep(1000);
                    Console.Write(". ");
                    Thread.Sleep(1000);
                    Console.WriteLine(". \n");
                    Console.WriteLine("Goodbye!");
                    return false;
                    
                }
                else
                {
                    InvalidReturn();
                }

            } while (userIn);
            return true;
        }

        public static void InvalidReturn()
        {
            Console.WriteLine("Invalid Entry, please select one of the following options.");

        }

    }
}

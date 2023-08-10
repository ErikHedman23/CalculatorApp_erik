using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp_erik
{
    public class ImplementCalcMethods : ICalculator
    {
        public double Addition { get ; set ; }
        public double Subtraction { get ; set ; }
        public double Multiplication { get ; set ; }
        public double Division { get ; set ; }
        public double Modulus { get ; set ; }
        public double SquareRoot { get ; set ; }

        public static double AddMethod(double num1, double num2)
        {
            
            return num1 + num2;
        }

        public static double DivisionMethod(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double ModulusMethod(double num1, double num2)
        {
            return num1 % num2;
        }

        public static double MultiplicationMethod(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double SquareRootMethod(double num1)
        {
            return num1 * num1;
        }

        public static double SubMethod(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}

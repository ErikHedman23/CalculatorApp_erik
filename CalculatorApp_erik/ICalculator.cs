using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp_erik
{
    public interface ICalculator
    {
        public double Addition { get; set; }
        public double Subtraction { get; set; }
        public double Multiplication { get; set; }
        public double Division { get; set; }
        public double Modulus { get; set; }
        public double SquareRoot { get; set; }

        public static abstract double AddMethod();
        public static abstract double SubMethod();
        public static abstract double MultiplicationMethod();
        public static abstract double DivisionMethod();
        public static abstract double ModulusMethod();
        public static abstract double SquareRootMethod();



    }
}

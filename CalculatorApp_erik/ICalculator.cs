using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp_erik
{
    public interface ICalculator
    {
        

        public static abstract double AddMethod(params double[] numbers);
        public static abstract double SubMethod(params double[] numbers);
        public static abstract double MultiplicationMethod(params double[] numbers);
        public static abstract double DivisionMethod(params double[] numbers);
        //public static abstract double ModulusMethod(params double[] numbers);
        public static abstract void SquareRootMethod();



    }
}

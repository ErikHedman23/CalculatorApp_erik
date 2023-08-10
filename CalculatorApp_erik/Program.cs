

using CalculatorApp_erik;
List<ICalculator> methodsStored = new List<ICalculator>();

Console.WriteLine("Welcome to your personal Calculator!");

var calcOptions = new ImplementCalcMethods();

do
{

    Console.WriteLine("Enter your first number:");
    var userInput = double.TryParse(Console.ReadLine(), out double fistNum);
    if (userInput == false)
    {
        Console.WriteLine("Invalid entry: try again\n");
    }
} while (false);
ImplementCalcMethods.Calculator();

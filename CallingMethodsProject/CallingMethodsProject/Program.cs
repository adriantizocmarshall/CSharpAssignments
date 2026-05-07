using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsProject
{
        class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to initialize: ");
            string firstInput = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstInput);

            MathOperations mathOps = new MathOperations(firstNumber);

            int doubledResult = mathOps.DoubleNumber(firstNumber);
            
            Console.WriteLine("\nWhen multiplied by 3, the resulting number is: " + doubledResult);

            Console.WriteLine("\nPlease enter another number:");
            string secondInput = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondInput);

            MathOperations mathOpsSecondStep = new MathOperations(secondNumber);
            int newNumber = mathOpsSecondStep.AddNumbers(secondNumber);

            Console.WriteLine("\nAdding " + secondNumber + " to " + 5 + " equals: " + newNumber);

            Console.WriteLine("\nPlease enter a number for use in the final calculation:");
            string finalInput = Console.ReadLine();
            int finalNumber = Convert.ToInt32(finalInput);

            MathOperations mathOpsThirdStep  = new MathOperations(finalNumber);
            int conclusiveNumber = mathOpsThirdStep.SubtractNumbers(finalNumber);
            
            Console.WriteLine("\nSubtracting " + finalNumber + " by " + 7 + " equals: " + conclusiveNumber);
            
            Console.WriteLine("\nProgram has executed successfully.");
        }
    }
}
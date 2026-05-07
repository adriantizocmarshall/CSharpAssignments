using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance of the OKCalculator class containing the method for calculation
            OKCalculator airbag = new OKCalculator();
            // User prompt to enter the first number to be included in the calculation
            Console.WriteLine("Please enter a number: ");
            string firstInput = Console.ReadLine();
            int numberOne = int.Parse(firstInput);

            // Prompt to enter the second number to be included in the calculation
            Console.WriteLine("Please enter another number (or press Enter to skip): ");
            string secondInput  = Console.ReadLine();

            if (string.IsNullOrEmpty(secondInput))
            {
                int result = airbag.Add(numberOne);
                Console.WriteLine($"Result using a value of 1 in place of user input: {numberOne} + 1 = {result}");
            }
            else
            {
                // Converts the user's number into an integer
                int numberTwo = Convert.ToInt32(secondInput);
                // Calls the Add method using the airbag object
                int result = airbag.Add(numberOne, numberTwo);
                Console.WriteLine($"Result using second entered number: {numberOne} + {numberTwo} = {result}");
            }

            // Waits for the user to press a key
            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
}

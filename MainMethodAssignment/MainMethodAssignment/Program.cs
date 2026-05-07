using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
        class Program
        {
            static void Main(string[] args)
            {
                // Create an instance of the MathProcessor class to access its methods
                MathMethod method  = new MathMethod();

                // Test the integer version of the ProcessNumber method
                Console.WriteLine("Testing integer processing:");

                // Define an integer input value
                int intInput = 5;

                // Call the ProcessNumber method with integer parameter and store the result
                int intResult = method.UserNumber(intInput);

                // Display the result of the integer operation to the console
                Console.WriteLine($"Processing integer {intInput}: Result = {intResult}");

                // Test the decimal version of the ProcessNumber method
                Console.WriteLine("\nTesting decimal processing:");

                // Define a decimal input value
                decimal decimalInput = 10.5m;

                // Call the ProcessNumber method with decimal parameter and store the result
                int decimalResult = method.UserNumber(decimalInput);

                // Display the result of the decimal operation to the console
                Console.WriteLine($"Processing decimal {decimalInput}: Result = {decimalResult}");

                // Test the string version of the ProcessNumber method
                Console.WriteLine("\nTesting string processing:");

                // Define a string input value that represents a number
                string stringInput = "7";

                // Call the ProcessNumber method with string parameter and store the result
                int stringResult = method.UserNumber(stringInput);

                // Display the result of the string operation to the console
                Console.WriteLine($"Processing string '{stringInput}': Result = {stringResult}");

                // Wait for user to press a key before closing the console window
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_StringsIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbersInitial = new List<double> { 100, 200, 300, 400, 500, 600 };
            Console.WriteLine("The first 6 numbers in the sequence are:");
            string numbersString = string.Join(", ", numbersInitial);
            Console.WriteLine(numbersString);

            double divisorNumber = 0; // Variable to store the divisor number
            bool validInput = false; // Declares a variable to check for valid user input

            // Checks for valid input using a try/catch block
            while (!validInput)
            {
                Console.WriteLine("\nPlease enter a number as a divisor: ");

                try
                {
                    string userInput = Console.ReadLine(); // Read user input

                    if (double.TryParse(userInput, out divisorNumber)) // Attempts to convert the user input to a double
                    {
                        if (divisorNumber != 0)
                        {
                            validInput = true; // Exit the loop when a valid input is received
                        }
                        else
                        {
                            Console.WriteLine("You cannot divide by zero. Please try again"); // Error message if user attempts to divide by zero
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid number entered. Please try again"); // Error message if user enters an invalid number
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading input: {ex.Message}. Please try again "); // Displays error message if there is an exception
                }
            }
            // Try/catch block for division

            try
            {
                foreach (double numberInput in numbersInitial)
                {
                    double result = numberInput / divisorNumber;
                    Console.WriteLine($"{numberInput} ÷ {divisorNumber} = {result}");
                    Console.ReadLine(); // For pacing of program
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error encountered during division operation: {ex.Message}"); // Prints error message to the console in the event of an exception
            }

            // A message that will appear after try/catch blocks
            Console.WriteLine("\nProgram has executed successfully, press any key to exit");
            Console.ReadKey(); // Reads user input from console
            }
        }
    }
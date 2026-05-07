using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a boolean to check if birthyear is valid
            bool isValidAge = false;

            // Loops until birthyear is valid
            while (!isValidAge)
            {
                // Ask the user for their age
                Console.WriteLine("Please enter your age:");

                try
                {                    
                    // Get user age and convert to an integer
                    int userAge = Convert.ToInt32(Console.ReadLine());

                    // Get current year
                    int currentYear = DateTime.Now.Year;

                    // Calculate birth year
                    int birthYear = currentYear - userAge;

                    // Checks if age is greater than zero
                    if (userAge > 0)
                    {
                        // Exit the loop
                        isValidAge = true;
                        Console.WriteLine($"\nThe year you were born was {birthYear}.");
                        Console.WriteLine("\nPress any key to exit.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid age. Please enter a positive number greater than zero.");
                    }
                }
                // Error handling if user enters a negative age or zero
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("\nInvalid age. Please enter a positive number greater than zero.");
                }
                // For any other exception
                catch (FormatException)
                {
                    Console.WriteLine("\nInvalid input. Please enter a numeric value.");
                }
            }
        }
    }
}

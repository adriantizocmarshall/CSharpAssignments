using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingEnumsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week:");

            // Read user input
            string userInput = Console.ReadLine();

            try
            {
                // Parse user input to Weekdays enum and assign entered value to a variable called currentDay
                Weekdays currentDay = (Weekdays)Enum.Parse(typeof(Weekdays), userInput, ignoreCase: true);

                // Print successfully parsed value
                Console.WriteLine($"The current day is: {currentDay}");
            }
            catch (ArgumentException)
            {
                // Print error message if the input doesn't match an enum value
                Console.WriteLine("Incorrect input, please try again.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicInsurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine()); // Reads user input for age and converts it to an integer
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? Please answer yes or no");
            string duiInput = Console.ReadLine(); // Reads user input for DUI question
            bool hasDUI = (duiInput == "yes"); // Checks if the user has typed "yes", which will result in a true value for hasDUI
            Console.ReadLine(); // Space for cleanliness in the console output
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine()); // Reads user input and converts into an integer
            
            bool isQualified = (age >= 15 && hasDUI == true && tickets <= 3); // Checks all conditions based on stored information and determines a value of true or false
            Console.ReadLine();
            if (isQualified == true) // Checks if the value of isQualified is true
            {
                Console.WriteLine("Congratulations! You qualify for insurance.");
                Console.ReadLine();
            }
            else // If the value of isQualified is false
            {
                Console.WriteLine("Sorry, you do not qualify for insurance.");
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}

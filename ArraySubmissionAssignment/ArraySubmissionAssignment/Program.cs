using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[] { "Hello", "this", "is", "an", "array" }; // Creates a string array with 5 elements
            string hereGoes = string.Join(" ", stringArray); // Joins the elements of the array into a string
            Console.WriteLine(hereGoes); // Prints the string so the user can see the complete array

            Console.WriteLine("\nPlease select a number between 0 and 4."); // Asks the user to select a number
            int numberChoice = Convert.ToInt32(Console.ReadLine()); // Converts the user's input to an integer
            bool validString = numberChoice >= 0 && numberChoice <= 4; // Checks if the user's input is valid
            while (!validString) // Loops until the user enters a number between 0 and 4
            {
                try
                {
                    Console.WriteLine("Selected number: " + numberChoice); // Prints the corresponding element of the array
                    string selectedElement = stringArray[numberChoice]; // Retrieves the selected element

                    if (selectedElement != null && !string.IsNullOrEmpty(selectedElement))
                    {
                        Console.WriteLine(selectedElement); // Prints the selected element
                        validString = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

                Console.WriteLine("\nPlease select a number between 0 and 4."); // Asks the user to select a number again
                numberChoice = Convert.ToInt32(Console.ReadLine()); // Converts the user's input to an integer
            }

            Console.WriteLine("\nYou selected: " + stringArray[numberChoice]); // Prints the selected element
            
            int[] numArray = new int[] { 500, 300, 100 }; // Creates an integer array with 3 elements
            Console.WriteLine("\nNext, please select a number between 0 and 2 and I'll give you a random number.");
            int secondChoice = Convert.ToInt32(Console.ReadLine()); // Converts the user's input to an integer
            bool validNum = secondChoice >= 0 && secondChoice <= 2; // Checks if the user's input is valid
            while (!validNum) // Loops until the user enters a number between 0 and 2
            {
                try
                {
                    Console.WriteLine("Selected number: " + secondChoice); // Prints the corresponding element of the array
                    string selectedNum = numArray[secondChoice].ToString(); // Retrieves the selected element and converts it to a string
                    
                    if (selectedNum != null && !string.IsNullOrEmpty(selectedNum))
                    {
                        Console.WriteLine(selectedNum); // Prints the selected element
                        validNum = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
                
                Console.WriteLine("\nThat won't work. Please enter a number between 0 and 2."); // Error message if the user enters an invalid number
                secondChoice = Convert.ToInt32(Console.ReadLine()); // Updates the value of secondChoice
            }

            Console.WriteLine("\nYou selected: " + numArray[secondChoice]);

            List<string> stringList = new List<string>(); // Creates a List of strings
            stringList.Add("Hello");
            stringList.Add("this");
            stringList.Add("is");
            stringList.Add("a");
            stringList.Add("list");
            Console.WriteLine("\nFinally, choose a random phrase by entering a number from 0 to 4.");
            int thirdChoice = Convert.ToInt32(Console.ReadLine()); // Converts the user's input to an integer
            bool validList = thirdChoice >= 0 && thirdChoice <= 4; // Checks if the user's input is valid
            while (!validList) // Loops until the user enters a number between 0 and 4
            {
                try
                {
                    Console.WriteLine("You selected: " + stringList[thirdChoice]);

                    if (stringList[thirdChoice] != null && !string.IsNullOrEmpty(stringList[thirdChoice]))
                    {
                        Console.WriteLine(stringList[thirdChoice]); // Prints the selected element
                        validList = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid input. Please try again."); // Error message if the user enters an invalid number
                }

                Console.WriteLine("\nThat won't work. Please enter a number between 0 and 4.");
                thirdChoice = Convert.ToInt32(Console.ReadLine()); // Updates the value of thirdChoice
            }

            Console.WriteLine("\nYou selected: " + stringList[thirdChoice]);
        }
    }
}

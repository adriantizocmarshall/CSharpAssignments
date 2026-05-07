using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPartOne
{
    internal class Program
    {
        private static Dictionary<string, string> numbersLabeled = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            List<string> pullString = new List<string> { "1", "2", "3", "3", "4", "5" };
            Dictionary<string, string> isUnique = new Dictionary<string, string>();

            foreach (string number in pullString)
            {
                if (numbersLabeled.ContainsKey(number))
                {
                    isUnique[number] = "duplicate"; // The number is a duplicate
                }
                else
                {
                    isUnique[number] = "unique"; // The number is unique
                    numbersLabeled[number] = number; // Add the number to the dictionary
                }
            }

            for (int i = 0; i < pullString.Count; i++)
            {
                string label = $"Entry {i + 1}";
                string number= pullString[i];

                numbersLabeled[label] = number;
                isUnique[label] = pullString.Count(x => x == number).ToString()== "1" ? "unique" : "duplicate"; // Check if the number is unique and assign "unique" or "duplicate"
                if (isUnique[label] == "duplicate")
                {
                    Console.WriteLine($"Entry {i + 1}: {number} (duplicate)");
                }
                else
                {
                    Console.WriteLine($"Entry {i + 1}: {number} (unique)");
                }
            }

            string joinString = string.Join(", ", pullString); // join the array with a comma and a space
            Console.WriteLine(joinString);
            Console.WriteLine("\nPress \"Enter\" to start.");
            Console.ReadLine();
            Console.WriteLine("\nPlease type the next number in the sequence and type done when finished adding numbers.");

            int count = 5; // Assigns a value of 5 to count, which will then be used to track how many numbers the user has entered and when to stop the loop
            string nextNumber;
            int entryCount = pullString.Count + 1; // Start entry count at the next number in the sequence

            while (true) // Loops until the user types done and fixes the loop at any point in the sequence
            {
                Console.Write("\nEnter a number or \"done\" to finish: \n");
                nextNumber = Console.ReadLine();

                // If the user types "done", it will break the loop and end the program
                if (nextNumber?.ToLower() == "done")
                {
                    break;
                }

                // Check that input is numeric and not greater than 10
                if (!checkValid(nextNumber))
                {
                    Console.WriteLine("\nInvalid input. Please enter a valid number or \"done\" to finish.");
                    continue; // Skip the rest of the loop and prompt again
                }

                if (!string.IsNullOrEmpty(nextNumber))
                {
                    string label = $"Entry {entryCount}"; // Create a label for the new number based on the current count of numbers in the list
                    pullString.Add(nextNumber); // Add valid number to the list
                    numbersLabeled[label] = nextNumber; // Add the new number to the dictionary with its label
                    count--; // Decrease count by 1 for each valid number added
                    entryCount++; // Increment entry count for the next label

                    joinString = string.Join(", ", pullString);
                    Console.WriteLine(joinString);
                    Console.WriteLine($"\nYou have {count} entries left."); // Inform the user how many entries they have left

                    // Prints whether the entered number is unique or duplicate
                    bool isDuplicate = pullString.Count(x => x == nextNumber) > 1;
                    if (isDuplicate)
                    {
                        Console.WriteLine($"Entry {nextNumber} is a duplicate.");
                    }
                    else
                    {
                        Console.WriteLine($"Entry {nextNumber} is unique.");
                    }

                    // Uses <= operator to check if count is less than or equal to 0, which means the user has entered 10 numbers and the loop should end
                    if (count <= 0)
                    {
                        Console.WriteLine("You have reached the maximum number of entries.");
                        break; // Exit the loop if listCount is less than or equal to 10
                    }
                }  
            }

            // Print all numbers in list on separate lines
            foreach (var entry in numbersLabeled)
            {
                Console.WriteLine($"\n{entry.Key}: {entry.Value}");
            }

            // Search feature
            SearchByIndex(pullString);

            Console.WriteLine("\n \nEnding program...");
            Console.ReadKey(); // Wait for user input before closing the console
        }

        // Method to search for a number in the dictionary
        private static void SearchByIndex(List<string> pullString)
        {
            while (true)
            {
                Console.WriteLine("\nEnter text to search for, or type \"exit\" to quit the search: ");
                string searchTerms = Console.ReadLine();

                //Checks if user wants to exit
                if (searchTerms?.ToLower() == "exit")
                {
                    break;
                }

                bool matchFound = false; // To track if the search found any matches

                // Loop through list and print matching entries, and set matchFound to true if any matches are found
                for (int i = 0; i < pullString.Count; i++)
                {
                    if (pullString[i].IndexOf(searchTerms, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        string label = $"Entry {i + 1}";
                        string number = pullString[i];
                        string status = numbersLabeled[label] == number ? "unique" : "duplicate";
                        Console.WriteLine($"\nEntry {i + 1}: {pullString[i]}");
                        matchFound = true; // Set matchFound to true if a match is found
                    }
                }

                // If no matches were found, inform user
                if (!matchFound)
                {
                    Console.WriteLine($"\nNo matching entries for \"{searchTerms}\".");
                }
            }
        }

        // Method to check if input is a valid number
        private static bool checkValid(string isValid)
        {
            return !string.IsNullOrEmpty(isValid) && int.TryParse(isValid, out _);
        }
    }
}
            
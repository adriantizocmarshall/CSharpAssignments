using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number!");
            int number;
            bool isValid = false; // Checks if the user input is valid

            // Validates user input and loops until it is valid
            while (!isValid)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            bool isGuessed = number == 12; // Checks if the user guessed the correct number

            do // Loops until the user guesses the correct number
            {
                switch (number) // Specific cases for each number guessed by the user, including the correct number
                {
                    case 62: // If the user guessed 62
                        Console.WriteLine("You guessed 62. Try again!");
                        Console.WriteLine("Guess a number!");

                        isValid = false; // Resets the validation to false
                        while (!isValid)
                        {
                            string input = Console.ReadLine();
                            if (int.TryParse(input, out number))
                            {
                                isValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                        }  // Loops until the user input is valid
                        break; // Breaks the loop
                    case 29: // If the user guessed 29
                        Console.WriteLine("You guessed 29. Try again!");
                        Console.WriteLine("Guess a number!");

                        isValid = false;
                        while (!isValid)
                        {
                            string input = Console.ReadLine();
                            if (int.TryParse(input, out number))
                            {
                                isValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                        }
                        break;
                    case 55: // If the user guessed 55
                        Console.WriteLine("You guessed 55. Try again!");
                        Console.WriteLine("Guess a number!");
                        
                        isValid = false;
                        while (!isValid)
                        {
                            string input = Console.ReadLine();
                            if (int.TryParse(input, out number))
                            {
                                isValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                        }
                        break;
                    case 12: // If the user guessed 12
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default: // If the user guessed any other number
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number!");

                        isValid = false;
                        while (!isValid)
                        {
                            string input = Console.ReadLine();
                            if (int.TryParse(input, out number))
                            {
                                isValid = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                            }
                        }
                        break;
                    }
                }
                while (!isGuessed); // Loops until the user guesses the correct number in collaboration with the do loop

                Console.Read();
            }
        }
    }

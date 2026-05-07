using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    // Static class containing a method that provides an integer by dividing the input number by three
    public static class IntegerClass
    {
        // Static method that divides an integer by three and returns the result
        public static int DivideByTwo(int number)
        {
            // Divides the input number by 3 and returns the result
            return number / 2;
        }
    }

    // Class containing various methods
    public class IntegerMethods
    {
        // Method that provides an integer by dividing input number by three
        public void DivideThenDisplay(int inputNumber)
        {
            // Divide the number provided to the method by three
            int divisionResult = inputNumber / 2;

            // Print the result to the console
            Console.WriteLine($"Input number ({inputNumber}) divided by two equals: {divisionResult}");
        }

        // Method that returns whether division was successful
        public bool TryDivideByTwo(int inputNumber, out int divisionResult)
        {
            // Perform division by three
            divisionResult = inputNumber / 2;

            // Return true if division was successful
            return true;
        }

        // Overloaded method that takes a double as input as opposed to an integer
        public bool TryDivideByTwo(double inputNumber, out double divisionResult)
        {
            // Perform division by three
            divisionResult = inputNumber / 2;

            // Return true if division was successful
            return true;
        }

        // Second overloaded method that takes three integers and returns an average divided by 3
        public bool TryDivideByTwo(int numberOne, int numberTwo, int numberThree, out int divisionResult)
        {
            // Calculate the average of three numbers
            int operationAverage = (numberOne + numberTwo + numberThree) / 2;

            // Divide the average by three
            divisionResult = operationAverage / 2;

            // Return true to indicate that the operation was successful
            return true;
        }
    }
}

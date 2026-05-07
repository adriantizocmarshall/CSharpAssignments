using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the IntegerClass method
            IntegerMethods intClass = new IntegerMethods();

            // Prompt user for input
            Console.WriteLine("Enter a number to be divided by 2: ");

            // Read user input and convert it to an integer
            string userInput = Console.ReadLine();
            int userNumber = Convert.ToInt32(userInput);

            // Call the DivideThenDisplay method
            intClass.DivideThenDisplay(userNumber);

            // Demonstrate the method and provide output parameters
            Console.WriteLine("\nUsing method with output parameter:");
            // Call the method with output parameter
            if (intClass.TryDivideByTwo(userNumber, out int outputResult))
            {
                // Display the output parameter
                Console.WriteLine($"Method with output parameter returned: {outputResult}");
            }

            // Demonstrate method overloading with different types of parameters
            Console.WriteLine("\nOverloading method...");
            // Call the overloaded method using a double
            if (intClass.TryDivideByTwo((double)userNumber, out double doubleResult))
            {
                Console.WriteLine($"Overloaded method using double returned: {doubleResult}");
            }

            //Call the overloaded method using three integers
            if (intClass.TryDivideByTwo(userNumber, userNumber * 3, userNumber * 4, out int intResult))
            {
                Console.WriteLine($"Overloaded method using three integers returned: {intResult}");
            }

            // Utilize static class for a demonstration
            Console.WriteLine("\nUsing static class method:");
            // Call the static method from the static class
            int staticResult = IntegerClass.DivideByTwo(userNumber);
            Console.WriteLine($"Static method result: {staticResult}");

            // Wait for user input before closing
            Console.WriteLine("\nPress any key to end program...");
            Console.ReadKey();
        }
    }
}

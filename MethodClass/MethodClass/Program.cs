using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathClass simpleMath = new MathClass();

            // Calls the method and passes parameters to calculate the sum
            Console.WriteLine("Calling method...");
            simpleMath.MathOperation(3, 5); // Uses three and five as parameters in the method

            // Waits for user input to proceed
            Console.WriteLine("\nPress any key to continue.");

            // Calls the method and specifies the parameters
            Console.WriteLine("Calling method with named parameters...");
            simpleMath.MathOperation(numberOne: 2, numberTwo: 4); // Parameters are explicitly specified

            // Second pause for user input
            Console.WriteLine();

            // A final pause before exiting program
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}

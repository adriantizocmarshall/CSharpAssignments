using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class MathClass
    {
        // Method that performs a math operation and displays the second number
        public void MathOperation(int numberOne, int numberTwo)
        {
            // Multiplies the first number by 5
            int operationResult = numberOne * 5;

            // Displays the result of the math operation
            Console.WriteLine($"First number ({numberOne}) multiplied by 5 is: {operationResult}");

            // Displays the second number
            Console.WriteLine($"Second number: {numberTwo}");
        }
    }
}

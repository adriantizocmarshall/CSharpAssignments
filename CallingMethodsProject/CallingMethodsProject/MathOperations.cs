using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsProject
{
    public class MathOperations
    {
        private int numberOne;

        public MathOperations(int startingNumber)
        {
            numberOne = startingNumber;
        }
        public int DoubleNumber(int numberOne)
        {
            return numberOne * 3;
        }

        public int AddNumbers(int numberOne)
        {
            return numberOne + 5;
        }

        public int SubtractNumbers(int numberOne)
        {
            return numberOne - 7;
        }
    }
}

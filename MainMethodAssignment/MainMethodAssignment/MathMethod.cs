using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    public class MathMethod // Class to overload a method three times using different data types
    {
        // The beginning method multiplying an integer by four
        public int UserNumber(int userInput)
        {
            return userInput * 4;
        }

        // This method takes a decimal as a parameter and returns an integer divided by two
        public int UserNumber(decimal userInput)
        {
            return (int)(userInput / 2);
        }

        // This method takes a string as a parameter and returns an integer plus six after parsing the string
        public int UserNumber(string userInput)
        {
            int parsedString = int.TryParse(userInput, out int result) ? result : 0;

            return parsedString + 6;
        }
    }
}


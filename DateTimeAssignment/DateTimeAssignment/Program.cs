using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stores the current time in a variable called currentTime
            DateTime currentTime = DateTime.Now;

            //Writes the current time to the console
            Console.WriteLine(currentTime);

            // Asks the user to enter a number between 1 and 10
            Console.WriteLine("\nPlease enter a number between 1 and 10.");

            // Stores the user's input as an integer called userNumber
            int userNumber = Convert.ToInt32(Console.ReadLine());

            // Adds the entered number stored in userNumber to the current time
            DateTime timePlus = currentTime.AddHours(userNumber);

            // Converts timePlus to a string called resultHour
            string resultHour = timePlus.ToString();

            // Prints out the expected time based on user's input
            Console.WriteLine($"In {userNumber} hours, it will be {resultHour}.");
        }
    }
}

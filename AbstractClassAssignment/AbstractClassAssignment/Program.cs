using PolymorphismAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                firstName = "Sample", // Sets firstName property inherited from Person
                lastName = "Student" //  Sets lastName property inherited from Person
            };

            // Calls the SayName() method for the Employee object
            employee.SayName();

            // Uses polymorphism to create an object with a type derived from IQuittable interface
            IQuittable quitter = employee;

            // Calls the Quit() method for the IQuittable object
            quitter.Quit();

            // Keeps console window open
            Console.WriteLine("Press any key to exit program");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsAssignment
{
    public class Person
    {
        // Property declaration to store first name
        public string FirstName { get; set; }
        // Property declaration to store last name
        public string LastName { get; set; }

        // Void method that prints the person's full name
        public virtual void SayName()
        {
            // Combines the first and last name properties to create a full name
            string fullName = FirstName + " " + LastName;

            // Writes the full name to the console with context
            Console.WriteLine("Name: " + fullName);
        }
    }

    // Defines Student class that inherits from Person class created above
    public class Employee : Person
    {
        // StudentID property to store student ID
        public int StudentID { get; set; }

        // Override SayName method
        public override void SayName()
        {
            // Calls the SayName method using the base class
            base.SayName();
        }
    }
}

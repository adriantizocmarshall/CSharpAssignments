using PolymorphismAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    // Define Person class with public access modifier to allow for inheritance
    public class Person
    {
        // Make firstName and lastName properties with public access modifier for additional classes to access
        public string firstName { get; set;}

        public string lastName { get; set;}

        // A method to display the person's name
        public virtual void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }
    }

    // Defines a public class called Employee that inherits from Person
    public class Employee : Person, IQuittable
    {
        // Creates a public integer property called ID that is specific to the Employee class
        public int Id { get; set;}

        // Implements the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has tendered their resignation.");
        }
    }
}

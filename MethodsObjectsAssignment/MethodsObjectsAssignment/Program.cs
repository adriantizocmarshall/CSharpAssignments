using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate object Student with first name "Some" and last name "Student"
            Employee employee = new Employee()
            {
                FirstName = "Some", // Set FirstName to "Some", inheriting from Student class
                LastName = "Student", // Set LastName to "Student", also from Student class
                StudentID = 123456789 // StudentID is specific to Student class
            };

            // Call SayName method using Person superclass as a reference for Student object
            employee.SayName();

            // Pause to keep window open and display results
            Console.WriteLine("Press any key to end program...");
            Console.ReadKey();
        }
    }
}

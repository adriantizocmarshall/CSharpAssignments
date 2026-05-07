using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of employees with 10 entries, two with FirstName Joe
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Franz", LastName = "Kafka"},
                new Employee { Id = 2, FirstName = "Albert", LastName = "Camus"},
                new Employee { Id = 3, FirstName = "Simone", LastName = "Beauvoir"},
                new Employee { Id = 4, FirstName = "Fyodor", LastName  = "Dostoevsky"},
                new Employee { Id = 5, FirstName = "Friedrich", LastName = "Nietzsche"},
                new Employee { Id = 6, FirstName = "Frantz", LastName = "Fanon"},
                new Employee { Id = 7, FirstName = "Joe", LastName = "Dirt"},
                new Employee { Id = 8, FirstName = "Martin", LastName = "Heidegger"},
                new Employee { Id = 9, FirstName = "Soren", LastName = "Kierkegaard"},
                new Employee { Id = 10, FirstName = "Joe", LastName = "Pesci"}
            };

            // New list to store employees with FirstName Joe
            List<Employee> joes = new List<Employee>();

            // foreach loop through employees from original list
            foreach (Employee employee in employees)
            {
                // If statement to check if FirstName is Joe
                if (employee.FirstName == "Joe")
                {
                    // Add employee to new list
                    joes.Add(employee);
                }
            }

            // Count and then display employees named Joe found using foreach loop
            Console.WriteLine($"Found {joes.Count} employees named Joe");

            // Lambda expression to repeat the previous task
            List<Employee> joeNew = employees.Where(employee => employee.FirstName == "Joe").ToList();
            Console.WriteLine($"Found {joeNew.Count} employees named Joe"); // Print lambda expression result

            // Display count of employees with ID greater than 5
            List<Employee> highFive = employees.Where(employee => employee.Id > 5).ToList();
            Console.WriteLine($"Found {highFive.Count} employees with ID greater than 5"); // Print second lambda expression result
        }
    }
}

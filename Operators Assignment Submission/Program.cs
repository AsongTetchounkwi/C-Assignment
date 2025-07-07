using System;

namespace EmployeeComparisonApp
{
    
    class Employee // Define the Employee class
    {
        // Public property to hold the employee's ID
        public int Id { get; set; }

        // Public property to hold employee's first name
        public string FirstName { get; set; }

        // Public property to hold employee's last name
        public string LastName { get; set; }

        // Overload the == operator to compare Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both are null, or both are the same instance, return true
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If either is null, return false
            if (emp1 is null || emp2 is null)
                return false;

            // Compare the Id values
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2); // Reuse the logic from == operator
        }

        // Override Equals to avoid warning (optional best practice)
        public override bool Equals(object obj)
        {
            return this == obj as Employee;
        }

        // Override GetHashCode when Equals is overridden (optional best practice)
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create the first Employee object
            Employee emp1 = new Employee
            {
                Id = 101,
                FirstName = "Asong",
                LastName = "Tetchounkwi"
            };

            // Create the second Employee object
            Employee emp2 = new Employee
            {
                Id = 102,
                FirstName = "Alice",
                LastName = "Bob"
            };

            // Compare both employees using the overloaded == operator
            bool areEqual = emp1 == emp2;

            // Display the comparison result to the console
            Console.WriteLine("Are the two employees equal? " + areEqual);

            // Change emp2's Id to match emp1 and test again
            emp2.Id = 101;
            areEqual = emp1 == emp2;

            // Display the updated comparison result
            Console.WriteLine("After changing emp2's Id to match emp1:");
            Console.WriteLine("Are the two employees equal now? " + areEqual);

            // Wait for user input before closing (optional for readability)
            Console.ReadLine();
        }
    }
}

using System;

public interface IQuittable // Defining the IQuittable interface
{
    // Declaring a method named Quit with no return value
    void Quit();
}

// Defining an Employee class that implements the IQuittable interface
public class Employee : IQuittable
{
    // Example properties for the Employee
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit method defined in the interface
    public void Quit()
    {
        // Custom implementation of what happens when the employee quits
        Console.WriteLine($"{FirstName} {LastName} has quit the job. Goodbye!");
    }
}

// Main program class
class Program
{
    // Entry point of the console application
    static void Main(string[] args)
    {
        // Create a new Employee object and assign first and last name
        Employee employee = new Employee()
        {
            FirstName = "Jane",
            LastName = "Doe"
        };

        // Use polymorphism: assign the Employee object to a variable of type IQuittable
        IQuittable quittable = employee;

        // Call the Quit method via the interface reference
        quittable.Quit();

        // Wait for user input to keep console window open
        Console.ReadLine();
    }
}

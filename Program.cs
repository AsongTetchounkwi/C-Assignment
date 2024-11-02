// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for package weight
        Console.Write("Enter the package weight (in pounds): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if weight exceeds 50 pounds
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express.");
            return; // End the program
        }

        // Prompt for package dimensions
        Console.Write("Enter the package width (in inches): ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the package height (in inches): ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the package length (in inches): ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if dimensions total exceeds 50 inches
        double totalDimensions = width + height + length;
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the quote
        double quote = (width * height * length * weight) / 100;

        // Display the quote to the user
        Console.WriteLine($"Your shipping quote is: ${quote:F2}");
    }
}

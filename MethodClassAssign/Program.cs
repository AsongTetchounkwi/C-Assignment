using System;

namespace ConsoleApp
{
    
    class MathOperations     // Creating a class named MathOperations
    {
        // Creating a void method that takes two integers
        public void DoMath(int num1, int num2)
        {
            // Performing a math operation on the first integer
            int result = num1 * 2;

            // Displaying the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // Displaying the second integer 
            Console.WriteLine("Second number is: " + num2);
        }
    }

    // Main class containing the entry point
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method, passing in two numbers
            mathOps.DoMath(5, 10);

            // Call the method, specifying the parameters by name
            mathOps.DoMath(num1: 7, num2: 3);

            // Pause the console so it doesn't close immediately
            Console.ReadLine();
        }
    }
}

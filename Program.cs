using System;

// Define a class named MathOperations
class MathOperations
{
    // Define a void method named PerformOperation that takes two integers as parameters
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Perform a simple math operation on the first integer (for example, doubling it)
        int result = firstNumber * 2;

        // Display the second integer to the screen
        Console.WriteLine($"Result: {result}, Second Number: {secondNumber}");
    }
}

// Entry point of the program
class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathObj = new MathOperations();

        // Call the PerformOperation method, passing in two numbers
        mathObj.PerformOperation(5, 10);

        // Call the PerformOperation method, specifying the parameters by name
        mathObj.PerformOperation(firstNumber: 8, secondNumber: 15);
    }
}
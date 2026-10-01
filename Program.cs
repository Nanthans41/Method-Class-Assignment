using System;

// This class contains the method required by the assignment.
public class MathOperations
{
    // This void method accepts two integer parameters.
    // The first integer is used in a math operation.
    // The second integer is displayed to the screen.
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Multiply the first number by 2 as the required math operation.
        int result = firstNumber * 2;

        // Display the result of the math operation on the first number.
        Console.WriteLine("The first number multiplied by 2 is: " + result);

        // Display the second number exactly as it was passed to the method.
        Console.WriteLine("The second number is: " + secondNumber);
    }
}

// This class contains the Main method where the console application starts.
class Program
{
    // The Main method is the starting point of the console application.
    static void Main(string[] args)
    {
        // Create an instance of the MathOperations class.
        MathOperations math = new MathOperations();

        // Call the method using two numbers as arguments.
        math.PerformOperation(10, 20);

        // Display a blank line to make the output easier to read.
        Console.WriteLine();

        // Call the same method again, but specify each parameter by name.
        // "firstNumber:" identifies the first parameter.
        // "secondNumber:" identifies the second parameter.
        math.PerformOperation(firstNumber: 30, secondNumber: 40);

        // Display a message asking the user to press a key before closing.
        Console.WriteLine("\nPress any key to exit.");

        // Wait for the user to press a key.
        Console.ReadKey();
    }
}

using System;

delegate int AddDelegate(int a, int b);

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the delegate
        AddDelegate addDelegate = AddNumbers;

        // Prompt the user to enter two numbers
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        // Call the delegate to add the numbers
        int sum = addDelegate(num1, num2);

        // Display the result
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
    }

    // Method to add two numbers
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}

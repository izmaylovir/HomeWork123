using System;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Subtract(int a, int b, int c)
    {
        return a - b - c;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Multiply(int a, int b, int c)
    {
        return a * b * c;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Division by zero is not allowed.");
        }
        return (double)a / b;
    }

    public double Divide(int a, int b, int c)
    {
        if (b == 0 || c == 0)
        {
            throw new ArgumentException("Division by zero is not allowed.");
        }
        return (double)a / b / c;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Addition:");
        Console.WriteLine(calculator.Add(5, 3)); 
        Console.WriteLine(calculator.Add(5, 3, 2)); 

        Console.WriteLine("\nSubtraction:");
        Console.WriteLine(calculator.Subtract(8, 3)); 
        Console.WriteLine(calculator.Subtract(8, 3, 2)); 

        Console.WriteLine("\nMultiplication:");
        Console.WriteLine(calculator.Multiply(4, 6)); 
        Console.WriteLine(calculator.Multiply(4, 6, 2)); 

        Console.WriteLine("\nDivision:");
        Console.WriteLine(calculator.Divide(10, 2)); 
        Console.WriteLine(calculator.Divide(10, 2, 2)); 
    }
}
public static class MathHelper
{
    public static int Square(int number)
    {
        return number * number;
    }
    public static int Cube(int number)
    {
        return number * number * number;
    }
    public static long Factorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Число должно быть неотрицательным.");

        long result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            Console.WriteLine($"Число: {number}");
            Console.WriteLine($"Квадрат: {MathHelper.Square(number)}");
            Console.WriteLine($"Куб: {MathHelper.Cube(number)}");
            Console.WriteLine($"Факториал: {MathHelper.Factorial(number)}");
            Console.WriteLine();
        }
    }
}

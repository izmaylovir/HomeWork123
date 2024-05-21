class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

        Console.WriteLine("Исходные значения: a = " + a + ", b = " + b);
        Calculate(ref a, ref b);
        Console.WriteLine("После вызова метода: a = " + a + ", b = " + b);
    }
    static void Calculate(ref int x, ref int y)
    {
        int sum = x + y;
        int product = x * y;
        x = sum;
        y = product;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int fib = GetFibonacci(7);
        Console.WriteLine(fib);
    }
    static int GetFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int a = 0;
        int b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
}
struct Point
{
    public int X;
    public int Y;
}

class Program
{
    static void Main()
    {
        Point point1 = new Point { X = 1, Y = 2 };
        Point point2 = new Point { X = 4, Y = 6 };

        double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        Console.WriteLine($"Длина отрезка между точками: {distance}");
    }
}
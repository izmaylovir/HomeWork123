public class Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect1 = new Rectangle(5.0, 3.0);
        Rectangle rect2 = new Rectangle(7.5, 2.5);
        Rectangle rect3 = new Rectangle(10.0, 4.0);
        Console.WriteLine($"Площадь первого прямоугольника: {rect1.GetArea()}");
        Console.WriteLine($"Площадь второго прямоугольника: {rect2.GetArea()}");
        Console.WriteLine($"Площадь третьего прямоугольника: {rect3.GetArea()}");
    }
}
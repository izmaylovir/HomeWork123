namespace l6t7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle circle1 = new Circle(3, 4); 
            Circle circle2 = new Circle(5); 
            Circle circle3 = new Circle("Red"); 
            Console.WriteLine(circle1);
            Console.WriteLine(circle2);
            Console.WriteLine(circle3);
        }
    }

    public struct Circle
    {
        public int X { get; }
        public int Y { get; }
        public double Radius { get; }
        public string Color { get; }
        public Circle(int x, int y)
        {
            X = x;
            Y = y;
            Radius = 1; 
            Color = "Default"; 
        }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            X = 2; 
            Y = 2; 
            Radius = radius;
            Color = "Default"; 
        }
        public Circle(string color)
        {
            X = 2; 
            Y = 2; 
            Radius = 1;
            Color = color;
        }

        public override string ToString()
        {
            return $"Circle: Center=({X}, {Y}), Radius={Radius}, Color={Color}";
        }
    }
}
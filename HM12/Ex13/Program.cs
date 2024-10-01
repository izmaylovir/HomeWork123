namespace l6t13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки (X1 Y1):");
            var input1 = Console.ReadLine().Split(' ');
            double X1 = Convert.ToDouble(input1[0]);
            double Y1 = Convert.ToDouble(input1[1]);
            Console.WriteLine("Введите координаты второй точки (X2 Y2):");
            var input2 = Console.ReadLine().Split(' ');
            double X2 = Convert.ToDouble(input2[0]);
            double Y2 = Convert.ToDouble(input2[1]);

            double distance = GetDistance(X1, Y1, X2, Y2);
            Console.WriteLine($"Расстояние между точками: {distance}");
        }
        public static double GetDistance(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }
    }
}
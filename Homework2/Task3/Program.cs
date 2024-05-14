{
    Console.Write("Введите начальную координату первого отрезка: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите конечную координату первого отрезка: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите начальную координату второго отрезка: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите конечную координату второго отрезка: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    bool intersect = (Math.Max(x1, x2) >= Math.Min(y1, y2)) && (Math.Max(y1, y2) >= Math.Min(x1, x2));
    Console.WriteLine("Отрезки пересекаются: " + intersect);
}

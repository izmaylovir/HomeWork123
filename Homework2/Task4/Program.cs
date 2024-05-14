{
    Console.Write("Введите коэффициент a: ");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите коэффициент b: ");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите коэффициент c: ");
    double c = Convert.ToDouble(Console.ReadLine());

    double discriminant = b * b - 4 * a * c;

    Console.WriteLine("Дискриминант: " + discriminant);

    if (discriminant == 0)
    {
        double root = -b / (2 * a);
        Console.WriteLine("Один корень: " + root);
    }
    else if (discriminant > 0)
    {
        double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine("Два корня: " + root1 + " и " + root2);
    }
    else
    {
        Console.WriteLine("Уравнение не имеет действительных корней.");
    }
}
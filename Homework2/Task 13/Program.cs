{
    Console.WriteLine("Введите три целых числа:");

    Console.Write("Первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Третье число (нижняя граница интервала): ");
    int lowerBound = Convert.ToInt32(Console.ReadLine());

    Console.Write("Четвертое число (верхняя граница интервала): ");
    int upperBound = Convert.ToInt32(Console.ReadLine());

    if ((num1 >= Math.Min(num2, lowerBound)) && (num1 <= Math.Max(num2, upperBound)))
    {
        Console.WriteLine("Первое число попадает в заданный интервал.");
    }
    else
    {
        Console.WrteLine("Первое число не попадает в заданный интервал.");
    }
}
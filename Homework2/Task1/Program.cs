{
    Console.Write("Введите первое целое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int minNum = Math.Min(num1, num2);
    Console.WriteLine("Минимальное число: " + minNum);
}
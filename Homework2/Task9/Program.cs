{
    Console.Write("Введите целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    bool isEven = number % 2 == 0;
    Console.WriteLine(isEven);
}
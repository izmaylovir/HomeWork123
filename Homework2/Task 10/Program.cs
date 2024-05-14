{
    Console.Write("Введите двузначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number < 10 || number > 99)
    {
        Console.WriteLine("Пожалуйста, введите двузначное число.");
    }
    else
    {
        int firstDigit = number / 10;
        int secondDigit = number % 10;

        int maxDigit = Math.Max(firstDigit, secondDigit);

        Console.WriteLine($"Максимальная цифра в числе {number} - {maxDigit}");
    }
}
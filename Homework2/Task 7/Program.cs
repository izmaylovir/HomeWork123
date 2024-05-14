{
    Console.Write("Введите шестизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 100000 && number <= 999999)
    {
        int sumFirstHalf = (number / 100000) + ((number / 10000) % 10) + ((number / 1000) % 10);
        int sumSecondHalf = ((number / 100) % 10) + ((number / 10) % 10) + (number % 10);

        bool isLucky = sumFirstHalf == sumSecondHalf;
        Console.WriteLine(isLucky);
    }
    else
    {
        Console.WriteLine(false);
    }
}
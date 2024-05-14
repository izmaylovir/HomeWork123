{
    Console.Write("Введите четырехзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 1000 && number <= 9999)
    {
        int reverseNumber = (number % 10) * 1000 + ((number / 10) % 10) * 100 + ((number / 100) % 10) * 10 + (number / 1000);
        Console.WriteLine("Число в обратном порядке: " + reverseNumber);
    }
    else
    {
        Console.WriteLine("0");
    }
}
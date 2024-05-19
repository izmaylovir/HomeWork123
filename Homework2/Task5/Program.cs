{
    Console.Write("Введите двузначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 10 && number <= 99)
    {
        int reverseNumber = (number % 10) * 10 + (number / 10);
        Console.WriteLine("Число в обратном порядке: " + reverseNumber);
    }
    else
    {
        Console.WriteLine("0");
    }
}
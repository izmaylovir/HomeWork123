{
    Console.Write("Введите ваш возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age >= 18)
    {
        Console.WriteLine("Совершеннолетний");
    }
    else
    {
        Console.WriteLine("Несовершеннолетний");
    }
}
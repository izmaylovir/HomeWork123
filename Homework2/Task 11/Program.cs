{
    Console.Write("Введите ваше имя: ");
    string name = Console.ReadLine();

    Console.Write("Введите ваш возраст: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите ваш пол (м/ж): ");
    char gender = Convert.ToChar(Console.ReadLine());

    if (age < 14)
    {
        Console.WriteLine($"Увы, {name}, наш ресурс доступен для людей старше 14 лет.");
    }
    else
    {
        string greting = (gender == 'м') ? "Дорогой" : "Дорогая";
        Console.WriteLine($"{greting} {name}, добро пожаловать на наш ресурс!");
    }
}
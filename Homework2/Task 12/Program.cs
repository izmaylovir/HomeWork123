{
    Console.Write("Введите название дня недели: ");
    string dayOfWeek = Console.ReadLine();

    switch (dayOfWeek.ToLower())
    {
        case "суббота":
            case "воскресенье":
                Console.WriteLine("Сегодня выходной!");
            break;
        case "пятница":
            Console.WriteLine("Ура! Пятничка!");
            break;
        default:
            Console.WriteLine("Будний день");
            break;
    }
}
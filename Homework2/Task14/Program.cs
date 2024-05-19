﻿{
    Console.Write("Введите номер месяца (от 1 до 12): ");
    int month = Convert.ToInt32(Console.ReadLine());

    string season;

    switch (month)
    {
        case 12:
        case 1:
        case 2:
            season = "Зима";
            break;
        case 3:
        case 4:
        case 5:
            season = "Весна";
            break;
        case 6:
        case 7:
        case 8:
            season = "Лето";
            break;
        case 9:
        case 10:
        case 11:
            season = "Осень";
            break;
        default:
            season = "Некорректый номер месяца";
            break;
    }

    Console.WriteLine($"Месяц {month} относится к времени года: {season}");
}
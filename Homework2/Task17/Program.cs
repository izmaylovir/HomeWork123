using System;

{
    Console.Write("Введите оценку (от 1 до 5): ");
    int grade = Convert.ToInt32(Console.ReadLine());

    switch (grade)
    {
        case 5:
            Console.WriteLine("Отлично");
            break;
        case 4:
            Console.WriteLine("Хорошо");
            break;
        case 3:
            Console.WriteLine("Удовлетворительно");
            break;
        case 2:
        case 1:
            Console.WriteLine("Неудовлетворительно");
            break;
        default:
            Console.WriteLine("Некорректная оценка");
            break;
    }
}
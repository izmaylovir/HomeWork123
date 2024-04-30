//Задание 1 
{
    Console.WriteLine("Задание 1:")
    Console.WriteLine("Введите вашу фамилию");
    string lastname = Console.ReadLine();
    Console.WriteLine("Введите ваше имя");
    string firstname = Console.ReadLine();
    Console.WriteLine("Введите ваш пол");
    string gender = Console.ReadLine();
    Console.WriteLine($"Ваше имя:{firstname} {lastname}");
    Console.WriteLine($"Ваш пол:{gender}");
}

// Задание 2 
{
    Console.WriteLine("Введите наименование продукта:");
    string productname = Console.ReadLine();
    Console.WriteLine("Введите количество:");
    int quantity = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите цену:");
    double price = double.Parse(Console.ReadLine());
    Console.WriteLine($"Название: {productname}, кол-во: {quantity}, цена: {price}");
}

// Задание 3
{
    Console.WriteLine("Введите ваше имя");
    string firstname = Console.ReadLine();
    Console.WriteLine($"Привет,{firstname}");
}
// Задание 4 
{
    Console.WriteLine("Введите вашу фамилию");
    string lastname = Console.ReadLine();
    Console.WriteLine("Введите ваше имя");
    string firstname = Console.ReadLine();
    Console.WriteLine("Введите ваше отчество");
    string patronymic = Console.ReadLine();
    Console.WriteLine($"Привет:{lastname} {patronymic} {lastname}");
}
// Задание 5 

{
    Console.WriteLine("Введите количество метров:");
    int meters = Convert.ToInt32(Console.ReadLine());
    int kilometers = meters / 1000;
    Console.WriteLine($"Количество километров: {kilometers}");
}
// Задание 6
{
    Console.WriteLine("Введите количество километров:");
    int kilometrs = Convert.ToInt32(Console.ReadLine());

    int meters = kilometrs * 1000;
    Console.WriteLine($"Количество метров: {meters}");
}
// Задание 7
{
    Console.WriteLine("Введите кол-во минут");
    int minutes = Convert.ToInt32(Console.ReadLine());
    int hour = minutes / 60;
    Console.WriteLine($"Кол-во часов:{hour}");
}
//Задание 8 
{
    Console.WriteLine("Введите кол-во часов");
    int hour = Convert.ToInt32(Console.ReadLine());
    int day = hour / 24;
    Console.WriteLine($"Кол-во дней:{day}");
}
//Задание 9
{

    Console.WriteLine("Введите количество дней:");
    int days = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество часов:");
    int hours = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество минут:");
    int minutes = Convert.ToInt32(Console.ReadLine());
    int totalMinutes = days * 24 * 60 + hours * 60 + minutes;
    Console.WriteLine($"Общее количество минут: {totalMinutes}");
}
// Задание 10
{
    Console.Write("Введите первое целое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int sum = num1 + num2;
    int difference = num1 - num2;
    int product = num1 * num2;
    int quotient = (int)num1 / num2;
    Console.WriteLine("Сумма: " + sum);
    Console.WriteLine("Разность: " + difference);
    Console.WriteLine("Произведение: " + product);
    Console.WriteLine("Частное: " + quotient);
}
//Задание 11 
{
    Console.Write("Введите первое целое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье целое число: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int sum = num1 + num2 + num3;
    Console.WriteLine("Сумма трех чисел: " + sum);
}
//Задание 12
{
    Console.Write("Введите температуру в градусах Цельсия: ");
    double celsius = Convert.ToDouble(Console.ReadLine());
    double fahrenheit = (celsius * 9 / 5) + 32;
    Console.WriteLine("Температура в градусах Фаренгейта: " + fahrenheit);
}
//Задание 13 
{
    Console.Write("Введите двузначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int first = number / 10; int second = number % 10;
    Console.WriteLine("Первая цифра: " + first);
    Console.WriteLine("Вторая цифра: " + second);
}
//Задание 14 
{
    Console.Write("Введите ширину прямоугольника: ");
    double width = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите длину прямоугольника: ");
    double length = Convert.ToDouble(Console.ReadLine());
    double perimeter = 2 * (width + length);
    double area = width * length;
    Console.WriteLine("Периметр прямоугольника: " + perimeter);
    Console.WriteLine("Площадь прямоугольника: " + area);
}
//Задание 15
{
    Console.Write("Введите радиус окружности: ");
    double r = Convert.ToDouble(Console.ReadLine());
    // TODO: заменить r * r на использование специального метода из класса Math
    double area = Math.PI * r * r;
    Console.WriteLine("Площадь окружности: " + area);
}
//Задание 16
{
    Console.Write("Введите первое целое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    // TODO: переписать без создания дополнительных переменных
    int a = number1;
    number1 = number2;
    number2 = a;
    Console.WriteLine("Первое число после обмена: " + number1);
    Console.WriteLine("Второе число после обмена: " + number2);
}
//Задание 17
{
    Console.Write("Введите количество рублей: ");
    int rubles = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите курс покупки доллара: ");
    int buydollar = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите комиссию банка в рублях: ");
    int bankcommission = Convert.ToInt32(Console.ReadLine());
    int dollars = (rubles - bankcommission) / buydollar;
    Console.WriteLine("Получено долларов: " + dollars);
}
//Задание 18
{
    Console.Write("Введите необходимое количество долларов: ");
    double dollars = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите курс покупки доллара: ");
    double buydollars = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите комиссию банка в рублях: ");
    double bankcommission = Convert.ToDouble(Console.ReadLine());
    double rubles = dollars * buydollars + bankcommission;
    Console.WriteLine("Необходимо рублей: " + rubles);
}
//Задание 19 
{
    Console.Write("Введите ширину параллелепипеда: ");
    double width = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите длину параллелепипеда: ");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите высоту параллелепипеда: ");
    double height = Convert.ToDouble(Console.ReadLine());
    double volume = width * length * height;
    Console.WriteLine("Объем параллелепипеда: " + volume);
}
//Задание 20 
{
    Console.Write("Введите ширину параллелепипеда: ");
    double width = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите длину параллелепипеда: ");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите высоту параллелепипеда: ");
    double height = Convert.ToDouble(Console.ReadLine());
    double volume = width * length * height;
    Console.WriteLine("Объем параллелепипеда: " + volume);
}
//Задание 21
{
    Console.Write("Введите букву: ");
    char letter = Console.ReadKey().KeyChar;
    int code = (int)letter;
    Console.WriteLine();
    Console.WriteLine("Код введенной буквы: " + code);
}
//Задание 22 
{
    Console.Write("Введите букву: ");
    char letter = Console.ReadKey().KeyChar;
    int code = (int)letter;
    Console.WriteLine();
    Console.WriteLine("Код введенной буквы: " + code);
}
//Задание 23

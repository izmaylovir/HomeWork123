//Задание 1 
{
    Console.WriteLine("Задание 1:");
    Console.WriteLine("Введите вашу фамилию");
    string lastname = Console.ReadLine();
    Console.WriteLine("Введите ваше имя");
    string firstname = Console.ReadLine();
    Console.WriteLine("Введите ваш пол");
    string gender = Console.ReadLine();
    Console.WriteLine($"Ваше имя:{firstname} {lastname} {gender}");
}
//8786877789
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
  static void Main()
  {
   Console.Write("Введите ваше имя: ");
   string name = Console.ReadLine();
   Console.WriteLine("Привет, " + name + "!");
    }
}
// Задание 4 
{
    Console.WriteLine("Введите вашу фамилию");
    string lastname = Console.ReadLine();
    Console.WriteLine("Введите ваше имя");
    string firstname = Console.ReadLine();
    Console.WriteLine("Введите ваше отчество");
    string patronymic = Console.ReadLine();
    Console.WriteLine($"Привет:{lastname} {patronymic} {firstname}");
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
    static void Main()
    {
    Console.Write("Введите два целых числа ");
    string input = Console.ReadLine();
    string[] numbers = input.Split(' ');
    int number1 = Convert.ToInt32(numbers[0]);
    int number2 = Convert.ToInt32(numbers[1]);
    int sum = number1 + number2;
    int difference = number1 - number2;
    int product = number1 * number2;
    double quotient = (double)number1 / number2;
    Console.WriteLine($"Сумма: {sum}");
    Console.WriteLine($"Разность: {difference}");
    Console.WriteLine($"Произведение: {product}");
    Console.WriteLine($"Частное: {quotient}");
   }
}
//Задание 11 
class Program
{
    static void Main()
    {
        Console.Write("Введите три числа ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');
        int sum = 0;

        foreach (string number in numbers)
        {
            sum += Convert.ToInt32(number);
        }

        Console.WriteLine("Сумма введенных чисел: " + sum);
    }
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
   {
    static void Main()
    {
    double radius, area;
    const double pi = Math.PI;
    Console.Write("Введите радиус окружности: ");
    radius = Convert.ToDouble(Console.ReadLine());
    area = pi * Math.Pow(radius, 2);
    Console.WriteLine($"Площадь окружности: {area}");
   }
}
}
//Задание 16
{
    static void Main()
    {
     int number1, number2;
     Console.Write("Введите первое целое число: ");
     number1 = Convert.ToDouble(Console.ReadLine());
     Console.Write("Введите второе целое число: ");
     number2 = Convert.ToDouble(Console.ReadLine());
     Console.WriteLine($"Исходные числа: {number1}, {number2}");
        (number1, number2) = (number2, number1);
        Console.WriteLine($"Числа после обмена: {number1}, {number2}");
    }
}
//Задание 17
{
    Console.Write("Введите количество рублей: ");
    double rubles = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите курс покупки доллара: ");
    double buydollar = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите комиссию банка в рублях: ");
    double bankcommission = Convert.ToInt32(Console.ReadLine());
    double dollars = (rubles - bankcommission) / buydollar;
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
    Console.WriteLine("Введите код символа:");
    int charCode = Convert.ToInt32(Console.ReadLine());
    char character = (char)charCode;
    Console.WriteLine($"Символ, соответствующий коду {charCode}, это: {character}");
}
//Задание 23
{
    Console.WriteLine("Введите координаты левого верхнего угла (x1, y1):");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты правого нижнего угла (x2, y2):");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int x3 = x1; // x-координата левого нижнего угла
    int y3 = y2; // y-координата левого нижнего угла
    int x4 = x2; // x-координата правого верхнего угла
    int y4 = y1; // y-координата правого верхнего угла
    Console.WriteLine($"Координаты левого нижнего угла: ({x3}, {y3})");
    Console.WriteLine($"Координаты правого верхнего угла: ({x4}, {y4})");
}
// Задание 24 
{
    Console.WriteLine("Введите тип преобразования (например, 'доллары в рубли', 'километры в мили', 'градусы Цельсия в Фаренгейты'):");
    string input = Console.ReadLine();
//Задание 1 
 {
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int minNum = Math.Min(num1, num2);
Console.WriteLine("Минимальное число: " + minNum); 
}
// Задание 2 
 {
 Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
 double num2 = Convert.ToDouble(Console.ReadLine());
 Console.Write("Введите третье число: ");
 double num3 = Convert.ToDouble(Console.ReadLine());
 double maxNum = Math.Max(num1, Math.Max(num2, num3));
 Console.WriteLine("Максимальное число: " + maxNum);
    }
//Задание 3
{
 Console.Write("Введите начальную координату первого отрезка: ");
 double x1 = Convert.ToDouble(Console.ReadLine());
 Console.Write("Введите конечную координату первого отрезка: ");
 double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите начальную координату второго отрезка: ");
double y1 = Convert.ToDouble(Console.ReadLine());
 Console.Write("Введите конечную координату второго отрезка: ");
 double y2 = Convert.ToDouble(Console.ReadLine());
 bool intersect = (Math.Max(x1, x2) >= Math.Min(y1, y2)) && (Math.Max(y1, y2) >= Math.Min(x1, x2));
 Console.WriteLine("Отрезки пересекаются: " + intersect);
    }
    //Задание 4 
   
    {
        Console.Write("Введите коэффициент a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        
        Console.WriteLine("Дискриминант: " + discriminant);

        if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine("Один корень: " + root);
        }
        else if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Два корня: " + root1 + " и " + root2);
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }
        // Задание 5
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
    //Задание 6 
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
    // Задание 7 
    {
        Console.Write("Введите шестизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 100000 && number <= 999999)
        {
            int sumFirstHalf = (number / 100000) + ((number / 10000) % 10) + ((number / 1000) % 10);
            int sumSecondHalf = ((number / 100) % 10) + ((number / 10) % 10) + (number % 10);

            bool isLucky = sumFirstHalf == sumSeconHalf;
            Console.WriteLine(isLucky);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
    //Задание 8 
    {
        Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPositive = number > 0;
        Console.WriteLine(isPositive);
    }
    //Задание 9 
    {
        Console.Write("Введите целое число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isEven = number % 2 == 0;
        Console.WriteLine(isEven);
    }
    //Задание 10 
    {
        Console.Write("Введите двузначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 10 || number > 99)
        {
            Console.WriteLine("Пожалуйста, введите двузначное число.");
        }
        else
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;

            int maxDigit = Math.Max(firstDigit, secondDigit);

            Console.WriteLine($"Максимальная цифра в числе {number} - {maxDigit}");
        }
    }
    //Задание 11
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
            Console.WriteLine($"{greeting} {name}, добро пожаловать на наш ресурс!");
        }
    }
    // Задание 12
    {
        Console.Write("Введите название дня недели: ");
        string dayOfWeek = Console.ReadLine();

        switch (dayOfWeek.ToLower())
        {
            case "суббота":
            cae "воскресенье":
                Console.WriteLine("Сегодня выходной!");
                break;
            case "пятница":
                Console.WriteLine("Ура! Пятничка!");
                break;
            default:
                Console.WriteLine("Будний день");
                brea;
        }
    }
    // Задание 13 
    {
        Console.WriteLine("Введите три целых числа:");

        Console.Write("Первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Третье число (нижняя граница интервала): ");
        int lowerBound = Convert.ToInt32(Console.ReadLine());

        Console.Write("Четвертое число (верхняя граница интервала): ");
        int upperBound = Convert.ToInt32(Console.ReadLine());

        if ((num1 >= Math.Min(num2, lowerBound)) && (num1 <= Math.Max(num2, upperBound)))
        {
            Console.WriteLine("Первое число попадает в заданный интервал.");
        }
        else
        {
            Console.WrteLine("Первое число не попадает в заданный интервал.");
        }
    }
    // Задание 14
     {
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
                beak;
            default:
                season = "Некорректый номер месяца";
                break;
        }

        Console.WriteLine($"Месяц {month} относится к времени года: {season}");
    }
    //Задание 15
    {
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите символ операции (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = nm1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Некорректная операция");
                return;
        }

        Console.WriteLine($"Результат операции: {num1} {operation} {num2} = {result}");
    }
    //Задание 16 
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
    // Задание 17
     {
        Console.Write("Введите оценку (от 1 до 5): ");
        int grade = onvert.ToInt32(Console.ReadLine());

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
    //Задание 18
    {
        Console.WriteLine("Введите три числа:");

        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        int temp;

        if (num1 > num2);
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        if (num2 > num3);
        {
            temp = num2;
            num2 = num3;
            num3 = temp;
        }

        if (num1 > num2);
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }

        Console.WriteLine("Числа в порядке возрастания: {0}, {1}, {2}", num1, num2, num3);
    }
    // Задание 19 
    {
        Console.WriteLine("Введите оценку от 0 до 100:");
        int score = Convert.ToInt32(Console.ReadLine());

        char grade;

        if (score >= 90);
        {
            grade = 'A';
        }
        else if (score >= 80);
        {
            grade = 'B';
        }
        else if (score >= 70);
        {
            grade = 'C';
        }
        else if (score >= 60);
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        Console.WriteLine("Оценка: {0}", grade);
    }
    // Задание 20
    {
        int[] numbers = new int[4];

        Console.WriteLine("Введите четыре числа:");

        for (int i = 0 i < 4; i++);
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numbers);
        Array.Reverse(numbers);

        Console.WriteLine("Числа в порядке убывания:");
        {
            Console.WriteLine(num);
        }
    }
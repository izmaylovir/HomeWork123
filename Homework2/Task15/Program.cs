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
            result = num1 - num2;
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
﻿class NumberService
{
    public int CountPositiveNumbers(int count)
    {
        List<int> numbers = new List<int>();
        Random random = new Random();
        int positiveCount = 0;

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Введите число или нажмите Enter для генерации случайного числа:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                int randomNumber = random.Next(-100, 101); 
                Console.WriteLine("Сгенерировано случайное число: " + randomNumber);
                numbers.Add(randomNumber);
            }
            else
            {
                if (int.TryParse(input, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод числа. Попробуйте еще раз.");
                    i--;
                }
            }
        }

        foreach (int number in numbers)
        {
            if (number > 0)
            {
                positiveCount++;
            }
        }

        return positiveCount;
    }
}
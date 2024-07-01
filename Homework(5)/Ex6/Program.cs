class NumberService
{
    public int FindSmallestNumber(int count)
    {
        List<int> numbers = new List<int>();
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Введите число или нажмите Enter для генерации случайного числа:");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                int randomNumber = random.Next(1, 101); 
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

        return numbers.Min();
    }
}
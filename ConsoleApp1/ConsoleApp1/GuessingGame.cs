
using System.Security.Cryptography.X509Certificates;

internal class GuessingGame
{
    internal void Start()
    {

        Random random = new Random();
        int computerNumber = random.Next(1, 101);
        int userNumber = 0;
        int attempts = 0;
        Console.WriteLine("Добро пожаловать в игру 'Угадай число'");
        Console.WriteLine("Загадано число от 1 до 100.Угадайте его.");
        while (userNumber != computerNumber)
        {
            Console.WriteLine("Введите ваше число ");
            string guessString = Console.ReadLine();
            userNumber = int.Parse(guessString);
            if (userNumber < computerNumber)
                Console.WriteLine("Нужно число больше ");
            if (userNumber > computerNumber)
                Console.WriteLine("Нужно число меньше ");
            attempts++;
            if (userNumber == computerNumber)
                Console.WriteLine($"Поздравляем! Вы угадали Данное число:{computerNumber}Кол-во попыток:{attempts}");
        }

    }
}





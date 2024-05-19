{
    static void Main()
    {
        Console.Write("Введите оценку от 0 до 100: ");
        int score = Convert.ToInt32(Console.ReadLine());

        char grade = GetGrade(score);
        Console.WriteLine($"Оценка: {grade}");
    }

    static char GetGrade(int score)
    {
        if (score >= 90 && score <= 100)
        {
            return 'A';
        }
        else if (score >= 80 && score <= 89)
        {
            return 'B';
        }
        else if (score >= 70 && score <= 79)
        {
            return 'C';
        }
        else if (score >= 60 && score <= 69)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }
}
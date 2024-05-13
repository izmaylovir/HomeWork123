enum AccessType
{
    Создание,
    Удаление,
    Чтение,
    Обновление
}

class Program
{
    static void Main()
    {
        AccessType access = AccessType.Чтение;

        switch (access)
        {
            case AccessType.Создание:
                Console.WriteLine("Доступно создание");
                break;
            case AccessType.Удаление:
                Console.WriteLine("Доступно удаление");
                break;
            case AccessType.Чтение:
                Console.WriteLine("Доступно чтение");
                break;
            case AccessType.Обновление:
                Console.WriteLine("Доступно обновление");
                break;
            default:
                Console.WriteLine("Недопустимый тип доступа");
                break;
        }
    }
}
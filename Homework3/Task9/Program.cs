enum UnitsType
{
    Kilograms,
    Liters,
    Quantity,
}

class Program
{
    static void Main()
    {
        UnitsType units = UnitsType.Kilograms;
        int value = 2;

        switch (units)
        {
            case UnitsType.Kilograms:
                Console.WriteLine($"{value} кг.");
                break;
            case UnitsType.Liters:
                Console.WriteLine($"{value} л.");
                break;
            case UnitsType.Quantity:
                Console.WriteLine($"{value} шт.");
                break;
            default:
                Console.WriteLine("Неизвестный тип единиц измерения");
                break;
        }
    }
}
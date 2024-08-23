public class Counter
{
    private static int _count = 0;
    public Counter()
    {
        _count++;
        Console.WriteLine($"Создан объект Counter. Текущий счетчик: {_count}");
    }
    ~Counter()
    {
        _count--;
        Console.WriteLine($"Удален объект Counter. Текущий счетчик: {_count}");
    }
    public static int GetCount()
    {
        return _count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Начальное значение счетчика: {Counter.GetCount()}");
        Counter c1 = new Counter();
        Counter c2 = new Counter();
        Counter c3 = new Counter();

        Console.WriteLine($"Значение счетчика после создания объектов: {Counter.GetCount()}");
        c1 = null;
        c2 = null;
        c3 = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine($"Значение счетчика после удаления объектов: {Counter.GetCount()}");
    }
}
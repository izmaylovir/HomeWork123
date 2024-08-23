public class ResourceHolder
{
    private int[] _resources;
    public ResourceHolder(int size)
    {
        _resources = new int[size];
        Console.WriteLine($"Ресурс выделен: массив размером {size}.");
    }
    ~ResourceHolder()
    {
        _resources = null;
        Console.WriteLine("Ресурс освобожден.");
    }
    public void FillResources()
    {
        Random rand = new Random();
        for (int i = 0; i < _resources.Length; i++)
        {
            _resources[i] = rand.Next(1, 100);
        }
        Console.WriteLine("Ресурс заполнен случайными числами.");
    }
    public void DisplayResources()
    {
        Console.WriteLine("Содержимое ресурса:");
        foreach (var item in _resources)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ResourceHolder holder1 = new ResourceHolder(5);
        holder1.FillResources();
        holder1.DisplayResources();

        ResourceHolder holder2 = new ResourceHolder(3);
        holder2.FillResources();
        holder2.DisplayResources();
        holder1 = null;
        holder2 = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Сборка мусора завершена.");
    }
}
class DynamicArrayService
{
    private List<int> arrayList = new List<int>();

    public void AddElement(int element)
    {
        arrayList.Add(element);
        Console.WriteLine("Current number of elements: " + arrayList.Count);
    }

    public void RemoveElement(int value)
    {
        arrayList.Remove(value);
        Console.WriteLine("Remaining elements: " + string.Join(", ", arrayList));
    }

    public void FillWithRandomNumbers()
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            arrayList.Add(random.Next(1, 101));
        }
    }

    public void SearchElement(int value)
    {
        int index = arrayList.IndexOf(value);
        if (index != -1)
        {
            Console.WriteLine("Element found at index: " + index);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }

    public void PrintAllElements()
    {
        Console.WriteLine("All elements: " + string.Join(", ", arrayList));
    }

    static void Main()
    {
        DynamicArrayService dynamicArray = new DynamicArrayService();

        dynamicArray.AddElement(5);
        dynamicArray.AddElement(10);

        dynamicArray.RemoveElement(5);

        dynamicArray.FillWithRandomNumbers();

        dynamicArray.SearchElement(10);

        dynamicArray.PrintAllElements();
    }
}
class DynamicArrayService
{
    private List<int> arrayList = new List<int>();
    public void AddElement(int element)
    {
        arrayList.Add(element);
        Console.WriteLine("Current number of elements: " + arrayList.Count);
    }
    public void RemoveElement(int element)
    {
        arrayList.Remove(element);
        Console.WriteLine("Remaining elements: ");
        foreach (int e in arrayList)
        {
            Console.Write(e + " ");
        }
        Console.WriteLine();
    }
    public void FillWithRandomNumbers()
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++) 
        {
            int randomNumber = random.Next(1, 101);
            arrayList.Add(randomNumber);
        }
    }
    public void FindElement(int element)
    {
        int index = arrayList.IndexOf(element);
        if (index != -1)
        {
            Console.WriteLine("Index of element " + element + ": " + index);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
    public void PrintAllElements()
    {
        Console.WriteLine("All elements in the ArrayList: ");
        foreach (int element in arrayList)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
} 

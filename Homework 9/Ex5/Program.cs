class GenericCollectionService<T>
{
    private List<T> collection = new List<T>();

    public void AddElement(T element)
    {
        collection.Add(element);
        Console.WriteLine($"Current number of elements: {collection.Count}");
    }

    public void RemoveElement(T element)
    {
        collection.Remove(element);
        Console.WriteLine("Remaining elements:");
        PrintAllElements();
    }

    public void FindElement(T element)
    {
        int index = collection.IndexOf(element);
        Console.WriteLine($"Index of the element: {index}");
    }

    public void SortCollection(Comparison<T> comparison)
    {
        collection.Sort(comparison);
    }

    public void PrintAllElements()
    {
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }
}
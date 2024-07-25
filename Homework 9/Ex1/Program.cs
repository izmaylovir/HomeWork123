
using System.Collections;

public class DynamicArrayService
{
    private ArrayList arrayList;

    public DynamicArrayService()
    {
        arrayList = new ArrayList();
    }

    public void AddElement(int element)
    {
        arrayList.Add(element);
        Console.WriteLine("Текущее количество элементов: " + arrayList.Count);
    }

    public void RemoveElement(int element)
    {
        arrayList.Remove(element);
        Console.WriteLine("Оставшиеся элементы:");
        PrintAllElements();
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

    public void FindElementIndex(int element)
    {
        int index = arrayList.IndexOf(element);
        if (index != -1)
        {
            Console.WriteLine("Индекс элемента " + element + ": " + index);
        }
        else
        {
            Console.WriteLine("Элемент не найден.");
        }
    }

    public void PrintAllElements()
    {
        Console.WriteLine("Элементы в списке:");
        foreach (var element in arrayList)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        DynamicArrayService dynamicArrayService = new DynamicArrayService();

        dynamicArrayService.AddElement(5);
        dynamicArrayService.AddElement(10);

        dynamicArrayService.FillWithRandomNumbers();

        dynamicArrayService.RemoveElement(5);

        dynamicArrayService.FindElementIndex(10);

        dynamicArrayService.PrintAllElements();
    }
}
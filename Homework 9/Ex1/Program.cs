using System;
using System.Collections;
using System.Data.Common;

public class DynamicArrayService
{
    private ArrayList arrayList;

    public DynamicArrayService()
    {
        arrayList = new ArrayList();
    }

    public void AddElement(object element)
    {
        arrayList.Add(element);
        Console.WriteLine("Текущее количество элементов: " + arrayList.Count);
    }

    public void RemoveElement(object element)
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

    public void FindElement(object element)
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
    static void Main(string[] args)
    {
        DynamicArrayService service = new DynamicArrayService();
        service.AddElement("Cat");
        service.AddElement("Dog");
        service.RemoveElement("Cat");
        service.FillWithRandomNumbers();
        service.FindElement("Dog");
        service.PrintAllElements();
    }
}
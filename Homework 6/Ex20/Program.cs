public class ArrayService
{
    public static int[] RemoveElementByIndexFromIntArray(int[] array, int index)
    {
        int[] newArray = new int[array.Length - 1];
        Array.Copy(array, newArray, index);
        Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
        return newArray;
    }

    public static Person[] RemovePersonByIndexFromArray(Person[] array, int index)
    {
        Person[] newArray = new Person[array.Length - 1];
        Array.Copy(array, newArray, index);
        Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
        return newArray;
    }
   public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public static void Main()
    {
        int[] intArray = new int[] { 1, 2, 3, 4 };
        int indexToRemove = 2;
        int[] newArray = RemoveElementByIndexFromIntArray(intArray, indexToRemove);

        Console.WriteLine("Массив целых чисел после удаления элемента с индексом 2:");
        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Person[] personArray = new Person[]
        {
            new Person("Alice", 25),
            new Person("Bob", 30),
            new Person("Charlie", 35)
        };
        indexToRemove = 1;
        Person[] newPersonArray = RemovePersonByIndexFromArray(personArray, indexToRemove);

        Console.WriteLine("Массив объектов Person после удаления элемента с индексом 1:");
        foreach (Person person in newPersonArray)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
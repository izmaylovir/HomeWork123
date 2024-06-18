public class ArrayService
{
    public static int[] RemoveLastElementFromIntArray(int[] array)
    {
        int[] newArray = new int[array.Length - 1];
        Array.Copy(array, newArray, newArray.Length);
        return newArray;
    }

    public static Person[] RemoveLastPersonFromArray(Person[] array)
    {
        Person[] newArray = new Person[array.Length - 1];
        Array.Copy(array, newArray, newArray.Length);
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
        int[] intArray = new int[] { 1, 2, 3 };
        int[] newArray = RemoveLastElementFromIntArray(intArray);

        Console.WriteLine("Массив целых чисел после удаления последнего элемента:");
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
        Person[] newPersonArray = RemoveLastPersonFromArray(personArray);

        Console.WriteLine("Массив объектов Person после удаления последнего элемента:");
        foreach (Person person in newPersonArray)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
public class ArrayService
{
    public static int[] RemoveFirstElementFromIntArray(int[] array)
    {
        int[] newArray = new int[array.Length - 1];
        Array.Copy(array, 1, newArray, 0, newArray.Length);
        return newArray;
    }
    public static Person[] RemoveFirstPersonFromArray(Person[] array)
    {
        Person[] newArray = new Person[array.Length - 1];
        Array.Copy(array, 1, newArray, 0, newArray.Length);
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
        int[] newArray = RemoveFirstElementFromIntArray(intArray);

        Console.WriteLine("Массив целых чисел после удаления первого элемента:");
        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Person[] personArray = new Person[]
        {
            new Person("Arthur", 25),
            new Person("Danil", 30),
            new Person("Danial", 35)
        };
        Person[] newPersonArray = RemoveFirstPersonFromArray(personArray);

        Console.WriteLine("Массив объектов Person после удаления первого элемента:");
        foreach (Person person in newPersonArray)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
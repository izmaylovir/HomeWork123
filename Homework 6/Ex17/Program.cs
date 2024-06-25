using System;

public class ArrayService
{
    public static int[] AddElementToIntArray(int[] array, int newElement)
    {
        int[] newArray = new int[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[newArray.Length - 1] = newElement;
        return newArray;
    }

    public static Person[] AddPersonToArray(Person[] array, Person newPerson)
    {
        Person[] newArray = new Person[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[newArray.Length - 1] = newPerson;
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
        int newElement = 4;
        int[] newArray = AddElementToIntArray(intArray, newElement);

        Console.WriteLine("Массив целых чисел после добавления нового элемента:");
        foreach (int num in newArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Person[] personArray = new Person[]
        {
            new Person("Arthut", 25),
            new Person("Danil", 30)
        };
        Person newPerson = new Person("Charlie", 35);
        Person[] newPersonArray = AddPersonToArray(personArray, newPerson);

        Console.WriteLine("Массив объектов Person после добавления нового элемента:");
        foreach (Person person in newPersonArray)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
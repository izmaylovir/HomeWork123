public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class PersonService
{
    public static string[] GetNames(Person[] people)
    {
        string[] names = new string[people.Length];

        for (int i = 0; i < people.Length; i++)
        {
            names[i] = people[i].Name;
        }

        return names;
    }

    public static void Main()
    {
        Person[] people = new Person[]
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 28 }
        };

        string[] names = GetNames(people);

        Console.WriteLine("Массив имен:");
        foreach (string name in names)
        {
            Console.Write(name + " ");
        }
    }
}
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

public class PersonService
{
    public static double CalculateAverageAge(Person[] people)
    {
        if (people.Length == 0)
        {
            return 0;
        }

        int totalAge = 0;
        foreach (Person person in people)
        {
            totalAge += person.Age;
        }

        return (double)totalAge / people.Length;
    }

    public static void Main()
    {
        Person[] people = new Person[3];
        people[0] = new Person("Alice", 25);
        people[1] = new Person("Bob", 30);
        people[2] = new Person("Charlie", 20);

        double averageAge = CalculateAverageAge(people);
        Console.WriteLine("Средний возраст: " + averageAge);
    }
}
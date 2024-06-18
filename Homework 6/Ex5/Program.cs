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
    public static Person FindPersonWithMinAge(Person[] people)
    {
        if (people.Length == 0)
        {
            return null;
        }

        Person personWithMinAge = people[0];
        foreach (Person person in people)
        {
            if (person.Age < personWithMinAge.Age)
            {
                personWithMinAge = person;
            }
        }

        return personWithMinAge;
    }

    public static void Main()
    {
        Person[] people = new Person[3];
        people[0] = new Person("Alice", 25);
        people[1] = new Person("Bob", 30);
        people[2] = new Person("Charlie", 20);

        Person personWithMinAge = FindPersonWithMinAge(people);
        Console.WriteLine("Человек с минимальным возрастом: " + personWithMinAge.Name + " (" + personWithMinAge.Age + " лет)");
    }
}
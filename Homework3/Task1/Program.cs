class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person
        {
            Name = "Артур",
            Age = 18,
            Weight = 69
        };

        Person person2 = new Person
        {
            Name = "Елизавета",
            Age = 19,
            Weight = 42
        };

        Person personWithMinWeight = person1.Weight < person2.Weight ? person1 : person2;
        Person personWithMinAge = person1.Age < person2.Age ? person1 : person2;

        Console.WriteLine($"Человек с наименьшим весом: {personWithMinWeight.Name}");
        Console.WriteLine($"Человек с наименьшим возрастом: {personWithMinAge.Name}");
    }
}
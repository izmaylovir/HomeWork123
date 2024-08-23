public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public Person(string name) : this(name, 18)
    {
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person("Алексей", 25);
        Person person2 = new Person("Мария");
        Person person3 = new Person("Иван", 30);
        person1.DisplayInfo();
        person2.DisplayInfo();
        person3.DisplayInfo();
    }
}
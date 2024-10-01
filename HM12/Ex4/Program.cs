
namespace l6t4
{
    public class Human
    {
        public string Name { get; set; }
        public bool Sex { get; set; } 
        public int Age { get; set; }
        public Human(string name, bool sex, int age)
        {
            Name = name;
            Sex = sex;
            Age = age;
        }
        public override string ToString()
        {
            string gender = Sex ? "мужчина" : "женщина";
            return $"Меня зовут {Name}, я {gender}, мне {Age} лет.";
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Human person1 = new Human("Иван", true, 30);
            Human person2 = new Human("Анна", false, 25);
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
        }
    }
}
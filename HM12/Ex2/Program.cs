namespace l6t2
{
    public class Cat
    {
        private string name;
        private Cat motherCat;
        public Cat(string name, Cat motherCat)
        {
            this.name = name;
            this.motherCat = motherCat;
        }
        public override string ToString()
        {
            if (motherCat == null)
            {
                return $"Меня зовут {name} и я мама!";
            }
            else
            {
                return $"Меня зовут {name}, а мою маму зовут {motherCat.name}";
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Cat motherCat = new Cat("Мурка", null);
            Console.WriteLine(motherCat.ToString());
            Cat kitten = new Cat("Котенок", motherCat);
            Console.WriteLine(kitten.ToString());
        }
    }
}
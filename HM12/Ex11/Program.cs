namespace l6t11
{
    public class Program
    {
        public string s = "Красивая строка №1";

        public static void Main(string[] args)
        {
            Program p = new Program();
            Cat cat = new Cat();
            p.ChangeStringValue(ref p.s);
            p.ChangeStringValue(ref cat.name);

            Console.WriteLine(p.s);
            Console.WriteLine(cat.name);
        }
        public void ChangeStringValue(ref string s)
        {
            s = "ЧТО-ТО НОВОЕ";
        }

        public class Cat
        {
            public string name = "Красивое имя котика";
        }
    }
}
namespace  l6t1
{
   
    public class Cat
    {
        private static int catCount = 0;

        public static int CatCount
        {
            get { return catCount; }
        }

        public Cat()
        {

            catCount++;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 500; i++)
            {
                new Cat();
            }
            Console.WriteLine(Cat.CatCount);
        }
    }

}
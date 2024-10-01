namespace l6t5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = 57;
            int y = 20;
            Sum(ref x, y); 
            Console.WriteLine(x);
        }
        static void Sum(ref int x, int y) 
        {
            x = 77; 
        }
    }
}
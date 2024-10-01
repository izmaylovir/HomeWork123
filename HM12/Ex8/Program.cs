namespace l6t8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result; 
            Dif(10, 5, out result); 

            Console.WriteLine($"Разность: {result}"); 
        }
        public static void Dif(int a, int b, out int difference)
        {
            difference = a - b; 
        }
    }
}

namespace l6t6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int N = 10; 
            int[] randomArray = MakeIntArray(N); 

            int A = 50; 
            int r; 

            MakeCustomIntArray(randomArray, A, out r); 

            Console.WriteLine($"Количество элементов, меньше или равно {A}: {r}");
        }
        public static int[] MakeIntArray(int N)
        {
            Random random = new Random();
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = random.Next(1, 101); 
            }

            return array;
        }
        public static void MakeCustomIntArray(int[] array, int A, out int count)
        {
            count = 0; 

            foreach (int number in array)
            {
                if (number <= A)
                {
                    Console.WriteLine(number); 
                    count++; 
                }
            }
        }
    }
}
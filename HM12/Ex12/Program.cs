namespace l6t12
{
    public class Program
    {
        static int a = 10;
        static long b = 17;
        static double d = 10.11;
        static float f = 100.07f;
        static char c = 'q';

        public static void Main(string[] args)
        {
            Change(ref a);
            Change(ref b);
            Change(d); 
            Change(f); 
            Change(ref c);
            double result = a * b * d * f * (int)c; 
            Console.WriteLine("Результат перемножения: " + result);
        }

        public static void Change(int a)
        {
            a += a;
        }

        public static void Change(ref int a)
        {
            a += a;
        }

        public static void Change(long a)
        {
            a += a;
        }

        public static void Change(ref long a)
        {
            a += a;
        }

        public static void Change(double a)
        {
            a += a;
        }

        public static void Change(ref double a)
        {
            a += a;
        }

        public static void Change(float a)
        {
            a += a;
        }

        public static void Change(ref float a)
        {
            a += a;
        }

        public static void Change(char a)
        {
            a += a;
        }

        public static void Change(ref char a)
        {
            a += a;
        }
    }
}


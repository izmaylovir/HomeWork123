namespace l6t18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] arr = { 1.22, 1.7, 7.8, 2.4, 8, 2.3, 2.5, 2.6, 6, 17, 7, 8, 12, 1, 11, 12, 5, 7.2 };
            double average = arr.Average();
            List<double> resultList = new List<double>();
            foreach (var item in arr)
            {
                if (item >= average - 2 && item <= average + 2)
                {
                    resultList.Add(item);
                }
            }
            double[] resultArray = resultList.ToArray();
            foreach (var value in resultArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}
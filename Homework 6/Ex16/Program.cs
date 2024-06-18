public class ArrayService
{
    public static int[] SumArrays(int[] array1, int[] array2)
    {
        int maxLength = Math.Max(array1.Length, array2.Length);
        int[] result = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            int num1 = i < array1.Length ? array1[i] : 0;
            int num2 = i < array2.Length ? array2[i] : 0;

            result[i] = num1 + num2;
        }

        return result;
    }

    public static void Main()
    {
        int[] array1 = new int[] { 1, 2, 3 };
        int[] array2 = new int[] { 4, 5, 6, 7 };

        int[] sumArray = SumArrays(array1, array2);

        Console.WriteLine("Сумма двух массивов:");
        foreach (int num in sumArray)
        {
            Console.Write(num + " ");
        }
    }
}
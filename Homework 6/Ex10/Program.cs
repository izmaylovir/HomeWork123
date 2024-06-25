public class ArrayService
{
    public static bool CompareArrays(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }

        return true;
    }

    public static void Main()
    {
        int[] numbers1 = { 10, 5, 8, 20, 3 };
        int[] numbers2 = { 10, 5, 8, 20, 3 };

        bool result = CompareArrays(numbers1, numbers2);

        if (result)
        {
            Console.WriteLine("Массивы равны");
        }
        else
        {
            Console.WriteLine("Массивы не равны");
        }
    }
}

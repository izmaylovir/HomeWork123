using System;

namespace l6t16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < 10)
                {
                    arr1[i] = arr[i]; 
                }
                else
                {
                    arr2[i - 10] = arr[i]; 
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
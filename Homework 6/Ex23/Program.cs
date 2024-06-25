class Program
{
    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        int[] mergedArray = arr1.Concat(arr2).ToArray();
        return mergedArray;
    }
}
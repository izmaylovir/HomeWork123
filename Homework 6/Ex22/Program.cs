class Program
{
    static int[] RemoveElementsByValue(int[] arr, int value)
    {
        int[] newArr = arr.Where(val => val != value).ToArray();
        return newArr;
    }
}
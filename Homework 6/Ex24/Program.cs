class ArrayService
{
    public int[] GetSubArray(int[] arr, int startIndex, int endIndex)
    {
        if (startIndex < 0 || endIndex >= arr.Length || startIndex > endIndex)
        {
            throw new ArgumentException("Invalid start or end index for subarray");
        }

        int subArrayLength = endIndex - startIndex + 1;
        int[] subArray = new int[subArrayLength];

        Array.Copy(arr, startIndex, subArray, 0, subArrayLength);

        return subArray;
    }
}
class ArrayService
{
    public int FindSecondLargest(int[] arr)
    {
        if (arr.Length < 2)
        {
            throw new ArgumentException("Array must have at least two elements");
        }

        int firstMax = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int num in arr)
        {
            if (num > firstMax)
            {
                secondMax = firstMax;
                firstMax = num;
            }
            else if (num > secondMax && num != firstMax)
            {
                secondMax = num;
            }
        }

        return secondMax;
    }
}
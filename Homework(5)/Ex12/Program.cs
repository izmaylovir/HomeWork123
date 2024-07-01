class NumberService
{
    public int ReverseNumber(int number)
    {
        int reversedNumber = 0;
        while (number != 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number = number / 10;
        }
        return reversedNumber;
    }
}
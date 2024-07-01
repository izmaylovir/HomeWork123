class NumberService
{
    public double Power(int number, int exponent)
    {
        double result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= number;
        }
        return result;
    }
}
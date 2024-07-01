class NumberService
{
    public double CalculateDeposit(double initialAmount, double interestRate, int months)
    {
        double finalAmount = initialAmount;
        for (int i = 0; i < months; i++)
        {
            finalAmount += finalAmount * (interestRate / 100);
        }
        return finalAmount;
    }
}
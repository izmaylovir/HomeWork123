public class DecimalToBinaryConverter
{
    public static string ConvertDecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        string binaryNumber = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber;
    }

    public static void Main()
    {
        int decimalNumber = 42;
        string binaryResult = ConvertDecimalToBinary(decimalNumber);

        Console.WriteLine("Decimal number: " + decimalNumber);
        Console.WriteLine("Binary representation: " + binaryResult);
    }
}
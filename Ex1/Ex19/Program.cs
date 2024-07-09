using System.Text.RegularExpressions;

public class PhoneNumberUtils
{
    public static bool IsRussianMobilePhoneNumber(string phoneNumber)
    {
        string russianPhonePattern = @"^((\+7|7|8)+([0-9]){10})$";
        Regex regex = new Regex(russianPhonePattern);

        return regex.IsMatch(phoneNumber);
    }

    public static void Main()
    {
        string phoneNumber1 = "+79123456789";
        string phoneNumber2 = "89123456789";
        string phoneNumber3 = "1234567890";

        Console.WriteLine("Is " + phoneNumber1 + " a valid Russian mobile phone number? " + IsRussianMobilePhoneNumber(phoneNumber1));
        Console.WriteLine("Is " + phoneNumber2 + " a valid Russian mobile phone number? " + IsRussianMobilePhoneNumber(phoneNumber2));
        Console.WriteLine("Is " + phoneNumber3 + " a valid Russian mobile phone number? " + IsRussianMobilePhoneNumber(phoneNumber3));
    }
}
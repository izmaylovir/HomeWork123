public class PasswordValidator
{
    public static bool ValidatePassword(string password)
    {
        if (password.Length < 8)
        {
            return false;
        }
        bool hasUpperCase = false;
        foreach (char c in password)
        {
            if (char.IsUpper(c))
            {
                hasUpperCase = true;
                break;
            }
        }
        if (!hasUpperCase)
        {
            return false;
        }
        bool hasDigit = false;
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                hasDigit = true;
                break;
            }
        }
        if (!hasDigit)
        {
            return false;
        }
        return true;
    }

    public static void Main()
    {
        string password = "StrongP@ssw0rd";

        bool isValid = ValidatePassword(password);

        if (isValid)
        {
            Console.WriteLine("Пароль валидный.");
        }
        else
        {
            Console.WriteLine("Пароль невалидный.");
        }
    }
}
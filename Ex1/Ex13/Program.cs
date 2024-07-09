public class NameUtils
{
    public static string GetInitials(string lastName, string firstName, string middleName)
    {
        if (string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(firstName))
        {
            throw new ArgumentException("Фамилия и имя не могут быть пустыми.");
        }

        string initials = lastName + " " + char.ToUpper(firstName[0]) + ".";

        if (!string.IsNullOrEmpty(middleName))
        {
            initials += char.ToUpper(middleName[0]) + ".";
        }

        return initials;
    }

    public static void Main()
    {
        string lastName = "Иванов";
        string firstName = "Иван";
        string middleName = "Иванович";

        string initials = GetInitials(lastName, firstName, middleName);

        Console.WriteLine("Фамилия с инициалами: " + initials);
    }
}
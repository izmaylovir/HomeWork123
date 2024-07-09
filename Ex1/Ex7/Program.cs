public class CaesarCipher
{
    public static string Encrypt(string plainText, int key)
    {
        string encryptedText = "";
        foreach (char c in plainText)
        {
            if (char.IsLetter(c))
            {
                char shiftedChar = (char)(((c - 'a' + key) % 26) + 'a');
                encryptedText += shiftedChar;
            }
            else
            {
                encryptedText += c;
            }
        }
        return encryptedText;
    }

    public static void Main()
    {
        string plainText = "Hello, World!";
        int key = 3;

        string encryptedText = Encrypt(plainText.ToLower(), key);

        Console.WriteLine($"Зашифрованное сообщение: {encryptedText}");
    }
}
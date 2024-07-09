public class CaesarCipher
{
    public static string Decrypt(string encryptedText, int key)
    {
        string decryptedText = "";
        foreach (char c in encryptedText)
        {
            if (char.IsLetter(c))
            {
                char shiftedChar = (char)(((c - 'a' - key + 26) % 26) + 'a');
                decryptedText += shiftedChar;
            }
            else
            {
                decryptedText += c;
            }
        }
        return decryptedText;
    }

    public static void Main()
    {
        string encryptedText = "khoor, zruog!";
        int key = 3;

        string decryptedText = Decrypt(encryptedText.ToLower(), key);

        Console.WriteLine($"Расшифрованное сообщение: {decryptedText}");
    }
}
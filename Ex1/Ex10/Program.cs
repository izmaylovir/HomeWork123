public class VigenereCipher
{
    public static string Encrypt(string text, string key)
    {
        string encryptedText = "";
        int keyIndex = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            if (char.IsLetter(currentChar))
            {
                int shift = char.ToUpper(key[keyIndex % key.Length]) - 'A';
                char encryptedChar = (char)(((char.ToUpper(currentChar) + shift - 'A') % 26) + 'A');
                encryptedText += char.IsLower(text[i]) ? char.ToLower(encryptedChar) : encryptedChar;
                keyIndex++;
            }
            else
            {
                encryptedText += currentChar;
            }
        }

        return encryptedText;
    }

    public static string Decrypt(string text, string key)
    {
        string decryptedText = "";
        int keyIndex = 0;

        for (int i = 0; i < text.Length; i++)
        {
            char currentChar = text[i];
            if (char.IsLetter(currentChar))
            {
                int shift = char.ToUpper(key[keyIndex % key.Length]) - 'A';
                char decryptedChar = (char)(((char.ToUpper(currentChar) - shift - 'A' + 26) % 26) + 'A');
                decryptedText += char.IsLower(text[i]) ? char.ToLower(decryptedChar) : decryptedChar;
                keyIndex++;
            }
            else
            {
                decryptedText += currentChar;
            }
        }

        return decryptedText;
    }

    public static void Main()
    {
        string text = "Hello, World!";
        string key = "KEY";

        string encryptedText = Encrypt(text, key);
        string decryptedText = Decrypt(encryptedText, key);

        Console.WriteLine("Исходный текст: " + text);
        Console.WriteLine("Зашифрованный текст: " + encryptedText);
        Console.WriteLine("Дешифрованный текст: " + decryptedText);
    }
}
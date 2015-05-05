using System;
using System.Text;

public class EncodeDecode
{
    public static string EncodeDecodeText(string text, string cipher)
    {
        char[] textArray = text.ToCharArray();
        char[] cipherArray = cipher.ToCharArray();
        StringBuilder result = new StringBuilder();
        for (int i = 0, k = 0; i < textArray.Length; i++, k++)
        {
            if (k == cipherArray.Length)
            {
                k = 0;
            }

            result.Append((char)(textArray[i] ^ cipherArray[k]));
        }

        return result.ToString();
    }
    public static void Main()
    {
        string input = Console.ReadLine();
        string cipher = "1991";
        string decoded = EncodeDecodeText(input, cipher);
        string encoded = EncodeDecodeText(decoded, cipher);
        Console.WriteLine("Decoded: {0}\nEncoded: {1}", decoded, encoded);
    }
}
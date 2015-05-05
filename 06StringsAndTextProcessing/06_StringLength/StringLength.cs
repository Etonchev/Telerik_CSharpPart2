using System;
using System.Text;

public class StringLength
{
    public static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder(input);
        while (result.Length < 20)
        {
            result.Append("*");
        }

        Console.WriteLine(result);
    }
}
using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        foreach (var item in input)
        {
            result.Append(String.Format("\\u{1:X4}", item, (int)item));
        }

        Console.WriteLine(result);
    }
}
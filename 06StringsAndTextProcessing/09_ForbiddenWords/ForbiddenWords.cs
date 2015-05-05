using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        StringBuilder result = new StringBuilder(text);
        string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
        foreach (var item in forbiddenWords)
        {
            if (result.ToString().Contains(item))
            {
                result.Replace(item, new String('*', item.Length));
            }
        }

        Console.WriteLine(result);
    }
}
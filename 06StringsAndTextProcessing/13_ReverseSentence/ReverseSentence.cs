using System;
using System.Text;

class ReverseSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] reversedWords = input.Split(new char[] { ' ', '!', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(reversedWords);
        StringBuilder reversed = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(","))
            {
                reversedWords[i] += ",";
            }

            if (words[i].Contains("!"))
            {
                reversedWords[i] += "!";
            }
        }

        foreach (var item in reversedWords)
        {
            reversed.Append(item);
            reversed.Append(" ");
        }

        Console.WriteLine(reversed.ToString().TrimStart());
    }
}

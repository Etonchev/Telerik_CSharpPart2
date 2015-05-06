using System;
using System.Text;

class OrderWords
{
    static void Main()
    {
        string input = "bear elephant cat dog kangaroo";
        string[] words = input.Split(' ');
        Array.Sort(words);
        StringBuilder sortedWords = new StringBuilder();
        foreach (var item in words)
        {
            sortedWords.Append(item);
            sortedWords.Append(' ');
        }

        Console.WriteLine(sortedWords);
    }
}
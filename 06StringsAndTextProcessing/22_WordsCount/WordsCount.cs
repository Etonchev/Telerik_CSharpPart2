using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        string input = "Sample text text to to to count words words.";
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        foreach (var item in words)
        {
            if (wordCount.ContainsKey(item))
            {
                wordCount[item]++;
            }
            else
            {
                wordCount.Add(item, 1);
            }
        }

        foreach (var item in wordCount)
        {
            Console.WriteLine("{0, -20} -> {1} times", item.Key, item.Value);
        }
    }
}
using System;
using System.Text;

public class ExtractSentences
{
    public static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string wordToSearchFor = " in ";
        string[] sentences = text.Split('.', '!', '?');
        foreach (var item in sentences)
        {
            if (item.Contains(wordToSearchFor))
            {
                Console.Write(item.Trim() + ". ");
            }
        }

        Console.WriteLine();
    }
}
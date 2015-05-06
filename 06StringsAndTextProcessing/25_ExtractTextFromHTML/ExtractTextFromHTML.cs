using System;
using System.Text.RegularExpressions;

class ExtractTextFromHTML
{
    static void Main()
    {
        string input = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn intoskilful .NET software engineers.</p></body></html>";
        MatchCollection tags = Regex.Matches(input, @"((?<=^|>)[^><]+?(?=<|$))");
        foreach (Match tag in tags)
        {
            foreach (Capture capture in tag.Captures)
            {
                Console.WriteLine(capture.Value);
            }
        }
    }
}
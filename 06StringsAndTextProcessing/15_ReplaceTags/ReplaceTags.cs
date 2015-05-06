using System;

class ReplaceTags
{
    static void Main()
    {
        string input = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string openURL = "[URL=";
        string openURLEnd = "]";
        string closeURL = "[/URL]";
        for (int i = 0; i < input.Length - 11; i++)
        {
            if (input.Substring(i, 9) == "<a href=\"")
            {
                input = input.Replace("<a href=\"", openURL);
            }

            if (input.Substring(i, 2) == "\">")
            {
                input = input.Replace("\">", openURLEnd);
            }

            if (input.Substring(i, 4) == "</a>")
            {
                input = input.Replace("</a>", closeURL);
            }
        }

        Console.WriteLine(input);
    }
}
using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        char[] arrayText = text.ToCharArray();
        StringBuilder search = new StringBuilder();
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < arrayText.Length; i++)
        {
            if (arrayText[i] == '<')
            {
                i++;
                while (arrayText[i] != '>')
                {
                    search.Append(arrayText[i]);
                    i++;
                }
                i++;
            }
            if (search.ToString().Equals("upcase"))
            {
                while (arrayText[i] != '<')
                {
                    result.Append(Char.ToUpper(arrayText[i]));
                    i++;
                }
                search.Clear();
                i += 9;
            }
            result.Append(arrayText[i]);
        }

        Console.WriteLine(result);
    }
}
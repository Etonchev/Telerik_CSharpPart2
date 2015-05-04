using System;

class ParseTags
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        char[] arrayText = text.ToCharArray();
        string search = String.Empty;
        string result = String.Empty;
        for (int i = 0; i < arrayText.Length; i++)
        {
            if (arrayText[i] == '<')
            {
                i++;
                while(arrayText[i] != '>')
                {
                    search += arrayText[i];
                    i++;
                }
                i++;
            }
            if (search == "upcase")
            {
                while (arrayText[i] != '<')
                {
                    result += Char.ToUpper(arrayText[i]);
                    i++;
                }
                search = String.Empty;
                i += 9;
            }
            result += arrayText[i];
        }

        Console.WriteLine(result);
    }
}
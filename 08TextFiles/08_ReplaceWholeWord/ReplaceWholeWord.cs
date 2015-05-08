using System;
using System.Collections.Generic;
using System.IO;

class ReplaceSubstring
{
    static void Main()
    {
        List<string> linesList = new List<string>();
        StreamReader reader = new StreamReader(@"E:\text1.txt");
        using (reader)
        {
            string lines = reader.ReadLine();
            while (lines != null)
            {
                linesList.Add(System.Text.RegularExpressions.Regex.Replace(lines, "\\bstart\\b", "finish"));
                lines = reader.ReadLine();
            }
        }

        StreamWriter writer = new StreamWriter(@"E:\text1.txt");
        using (writer)
        {
            foreach (var line in linesList)
            {
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("File modified successfully !");
    }
}
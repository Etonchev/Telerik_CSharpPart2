using System;
using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter(@"E:\modified.txt");
        StreamReader reader = new StreamReader(@"E:\text1.txt");
        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();
                string pattern = "\\btest\\w*\\b";
                while (line != null)
                {
                    Regex regex = new Regex(pattern);
                    line = regex.Replace(line, String.Empty);
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

        Console.WriteLine("Test prefix remove successfulyy !");
    }
}
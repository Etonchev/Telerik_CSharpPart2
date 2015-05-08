using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class ExtractTextFromHTML
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"E:\text1.txt");
        StringBuilder fileText = new StringBuilder();
        using (reader)
        {
            char character = (char)reader.Read();
            while (!reader.EndOfStream)
            {
                if (character != '<')
                {
                    fileText.Append(character);
                    character = (char)reader.Read();
                }
                else
                {
                    while (character != '>')
                    {
                        character = (char)reader.Read();
                    }

                    character = (char)reader.Read();
                }
            }
        }

        StreamWriter writer = new StreamWriter(@"E:\text1.txt");
        using (writer)
        {
            writer.WriteLine(fileText);
        }

        Console.WriteLine("HTML tags removed successfully !");
    }
}
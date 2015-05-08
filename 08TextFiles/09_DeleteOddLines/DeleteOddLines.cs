using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
        List<string> evenLines = new List<string>();
        StreamReader reader = new StreamReader(@"E:\text1.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            int lineCount = 1;
            while (line != null)
            {
                if ((lineCount & 1) == 0)
                {
                    evenLines.Add(line);
                }

                lineCount++;
                line = reader.ReadLine();
            }
        }

        StreamWriter writer = new StreamWriter(@"E:\text1.txt");
        using (writer)
        {
            foreach (var line in evenLines)
            {
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("Odd lines deleted !");
    }
}
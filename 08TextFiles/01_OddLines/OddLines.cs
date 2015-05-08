using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"E:\asd.txt");
        using (reader)
        {
            int lineCount = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if ((lineCount & 1) == 1)
                {
                    Console.WriteLine(line);
                }

                line = reader.ReadLine();
                lineCount++;
            }
        }
    }
}
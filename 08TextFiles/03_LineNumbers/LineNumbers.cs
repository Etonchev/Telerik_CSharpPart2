using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        StreamWriter writer = new StreamWriter(@"E:\modified.txt");
        using (writer)
        {
            StreamReader reader = new StreamReader(@"E:\concatenated.txt");
            using (reader)
            {
                int lineCount = 1;
                string line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine("{0} {1}", lineCount, line);
                    line = reader.ReadLine();
                    lineCount++;
                }
            }

            Console.WriteLine("File created successfully !");
        }
    }
}
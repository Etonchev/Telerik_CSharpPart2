using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        int sameLinesCount = 0;
        int differentLinesCount = 0;
        StreamReader firstReader = new StreamReader(@"E:\text1.txt");
        StreamReader secondReader = new StreamReader(@"E:\text2.txt");
        using (firstReader)
        {
            using (secondReader)
            {
                string firstLine = firstReader.ReadLine();
                string secondLine = secondReader.ReadLine();
                while (firstLine != null && secondLine != null)
                {
                    if (firstLine == secondLine)
                    {
                        sameLinesCount++;
                    }
                    else
                    {
                        differentLinesCount++;
                    }

                    firstLine = firstReader.ReadLine();
                    secondLine = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Number of lines that are the same: {0}", sameLinesCount);
        Console.WriteLine("Number of different lines: {0}", differentLinesCount);
    }
}
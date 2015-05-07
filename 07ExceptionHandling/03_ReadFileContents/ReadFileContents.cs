using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        try
        {
            string filePath = @"E:\asd.txt";
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found !");
        }
    }
}
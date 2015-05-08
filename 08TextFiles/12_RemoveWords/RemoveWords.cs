using System;
using System.Collections.Generic;
using System.IO;

class RemoveWords
{
    static void Main()
    {
        try
        {
            StreamReader textRead = new StreamReader(@"E:\text1.txt");
            StreamReader wordsRead = new StreamReader(@"E:\words.txt");
            List<string> words = new List<string>();
            List<string> newText = new List<string>();
            using (wordsRead)
            {
                string line = wordsRead.ReadLine();
                while (line != null)
                {
                    words.Add(line);
                    line = wordsRead.ReadLine();
                }
            }

            using (textRead)
            {
                string line = textRead.ReadLine();
                while (line != null)
                {
                    foreach (var word in words)
                    {
                        line = line.Replace(word, string.Empty);
                    }

                    newText.Add(line);
                    line = textRead.ReadLine();
                }
            }

            StreamWriter writer = new StreamWriter(@"E:\text1.txt");
            using (writer)
            {
                foreach (var line in newText)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Words removed from the file successfully !");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found !");
        }

        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found !");
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
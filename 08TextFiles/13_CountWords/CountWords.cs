using System;
using System.Collections.Generic;
using System.IO;

class CountWords
{
    static void Main()
    {
        try
        {
            StreamReader readWords = new StreamReader(@"E:\words.txt");
            List<string> words = new List<string>();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            using (readWords)
            {
                string word = readWords.ReadLine();
                while (word != null)
                {
                    words.Add(word);
                    word = readWords.ReadLine();
                }
            }

            StreamReader readText = new StreamReader(@"E:\text1.txt");
            using (readText)
            {
                string line = readText.ReadLine();
                while (line != null)
                {
                    string[] wordsInLine = line.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var wordInLine in wordsInLine)
                    {
                        foreach (var wordToSearch in words)
                        {
                            if (string.Equals(wordInLine, wordToSearch))
                            {
                                if (!dictionary.ContainsKey(wordInLine))
                                {
                                    dictionary.Add(wordInLine, 1);
                                }
                                else
                                {
                                    dictionary[wordInLine]++;
                                }
                            }
                        }
                    }

                    line = readText.ReadLine();
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
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
using System;
using System.Text;

class WordDictionary
{
    static void Main()
    {
        string input = ".NET";
        string dictionary = ".NET - platform for  applications from Microsoft;CLR - managed execution environment for .NET;namespace - hierarchical organization of classes";
        string[] dictionaryData = dictionary.Split(new char[] { ';', '-' });
        input += " ";
        for (int i = 0; i < dictionaryData.Length; i++)
        {
            if (string.Compare(input, dictionaryData[i], true) == 0)
            {
                Console.WriteLine("{0}-{1}", input, dictionaryData[i + 1]);
            }
        }
    }
}
using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string input = "ttthhhiis iiisss aaa teest";
        StringBuilder letters = new StringBuilder();
        letters.Append(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                letters.Append(input[i]);
            }
        }

        Console.WriteLine(letters);
    }
}
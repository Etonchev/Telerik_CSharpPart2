using System;

class LettersCount
{
    static void Main()
    {
        string input = "Sample text for counting letters.";
        input = input.ToLower();
        int[] letterCount = new int[255];
        for (int i = 0; i < letterCount.Length; i++)
        {
            letterCount[i] = 0;
        }
        foreach (var letter in input)
        {
            letterCount[(int)letter]++;
        }

        for (int i = 97; i <= 122; i++)
        {
            if (letterCount[i] != 0)
            {
                Console.WriteLine("{0} -> {1} times", (char)i, letterCount[i]);
            }
        }
    }
}
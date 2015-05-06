using System;

class Palindromes
{
    static void Main()
    {
        string input = "Sample text with exe, lamal as palindromes";
        string[] words = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var item in words)
        {
            var reversedWord = item.ToCharArray();
            Array.Reverse(reversedWord);
            string reversedItem = new string(reversedWord);

            if (string.Compare(item, reversedItem, true) == 0)
            {
                Console.WriteLine(item);
            }
        }
    }
}
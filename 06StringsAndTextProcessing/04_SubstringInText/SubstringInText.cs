using System;

class SubstringInText
{
    static void Main()
    {
        string input = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".ToLower();
        Console.WriteLine("Substring:");
        string substring = Console.ReadLine().ToLower();
        int count = 0;
        for (int i = 0; i < input.Length - substring.Length; i++)
        {
            if (input.Substring(i, substring.Length).Equals(substring))
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
using System;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int bracketsCounter = 0;
        foreach (var item in input)
        {
            if (item == '(')
            {
                bracketsCounter++;
            }
            if (item == ')')
            {
                bracketsCounter--;
            }
        }

        if (bracketsCounter == 0)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Not correct");
        }
    }
}
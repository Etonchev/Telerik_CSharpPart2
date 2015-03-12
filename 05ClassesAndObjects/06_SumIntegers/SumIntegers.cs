using System;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter numbers: ");
        string input = Console.ReadLine();
        int sum = 0;
        string[] numbers = input.Split(' ');
        foreach (var item in numbers)
        {
            int currentNumber = Convert.ToInt32(item);
            sum += currentNumber;
        }

        Console.WriteLine(sum);
    }
}
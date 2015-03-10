using System;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("n= ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }

        Console.WriteLine();
        sortFunc(arr);
    }

    static void sortFunc(string[] arr)
    {
        int[] numberOfWords = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            numberOfWords[i] = arr[i].Length;
        }

        Array.Sort(numberOfWords, arr);
        foreach (var element in arr)
        {
            Console.WriteLine(element);
        }
    }
}

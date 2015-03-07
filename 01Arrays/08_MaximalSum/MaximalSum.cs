﻿using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}]: ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maxTemp = int.MinValue;
        int maxEnd = 0;
        int start = 0;
        int startTemp = 0;
        int end = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            maxEnd += arr[i];

            if (arr[i] > maxEnd)
            {
                maxEnd = arr[i];
                startTemp = i;
            }
            if (maxEnd > maxTemp)
            {
                maxTemp = maxEnd;
                start = startTemp;
                end = i;
            }
        }

        Console.WriteLine("Maximal sum is: {0}", maxTemp);

        for (int j = start; j <= end; j++)
        {
            Console.Write(arr[j] + " ");
        }
        Console.WriteLine();
    }
}
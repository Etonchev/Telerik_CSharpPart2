using System;

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
        int maximumSequenceSum = int.MinValue;
        int currentSequenceSum = 0;
        int maximumSequenceStart = 0;
        int currentSequenceStart = 0;
        int maximumSequenceEnd = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            currentSequenceSum += arr[i];

            if (arr[i] > currentSequenceSum)
            {
                currentSequenceSum = arr[i];
                currentSequenceStart = i;
            }
            if (currentSequenceSum > maximumSequenceSum)
            {
                maximumSequenceSum = currentSequenceSum;
                maximumSequenceStart = currentSequenceStart;
                maximumSequenceEnd = i;
            }
        }

        Console.WriteLine("Maximal sum is: {0}", maximumSequenceSum);

        for (int j = maximumSequenceStart; j <= maximumSequenceEnd; j++)
        {
            Console.Write(arr[j] + " ");
        }
        Console.WriteLine();
    }
}
using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Arrays size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{i}] = ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        int bestIndex = 0;
        int bestCount = 0;
        int currentCount = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] < array[i])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                    bestIndex = i;
                }
                currentCount = 1;
            }
        }

        if (currentCount > bestCount)
        {
            bestCount = currentCount;
            bestIndex = array.Length;
        }

        for (int i = bestIndex - bestCount; i < bestIndex; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
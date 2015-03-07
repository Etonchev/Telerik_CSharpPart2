using System;

class MaximalSequence
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

        int bestElem = 0;
        int bestCount = 0;
        int currentCount = 1;
        int currentElem = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (currentElem == array[i])
            {
                currentCount++;
            }
            else
            {
                bestElem = array[i - 1];
                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                }
                currentCount = 1;
                currentElem = array[i];
            }
        }

        if (currentCount > bestCount)
        {
            bestCount = currentCount;
            bestElem = currentElem;
        }

        for (int i = 0; i < bestCount; i++)
        {
            Console.Write(bestElem + " ");
        }

        Console.WriteLine();
    }
}
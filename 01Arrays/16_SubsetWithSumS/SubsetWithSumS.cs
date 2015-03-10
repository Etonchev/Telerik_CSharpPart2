using System;

class SubsetWithSumS
{
    static void Main()
    {
        int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int sum = 14;
        bool found = false;
        for (int i = 0; i < array.Length; i++)
        {
            int tempSum = 0;
            for (int j = i; j < array.Length; j++)
            {
                tempSum += array[j];
                if (tempSum == sum)
                {
                    found = true;
                }
            }
        }

        if (found)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

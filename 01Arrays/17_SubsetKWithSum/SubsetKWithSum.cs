using System;

class SubsetKWithSum
{
    static void Main()
    {
        int[] array = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int sum = 14;
        int k = 4;

        bool found = false;
        for (int i = 0; i < array.Length; i++)
        {
            int tempSum = 0;
            int counter = 0;
            for (int j = i; j < array.Length; j++)
            {
                tempSum += array[j];
                counter++;
                if (tempSum == sum)
                {
                    found = true;
                }
                if (counter > k)
                {
                    break;
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

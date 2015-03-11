using System;

class FirstLargerThanNeighbours
{
    public static int LargerThanNeighbours(int[] array)
    {
        int foundIndex = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i - 1] < array[i] && array[i + 1] < array[i])
            {
                foundIndex = i;
            }
        }

        return foundIndex;
    }
    static void Main()
    {
        int[] array = { 1, 2, 3, 3, 5, 4, 3, 9 };
        Console.WriteLine(LargerThanNeighbours(array));
    }
}
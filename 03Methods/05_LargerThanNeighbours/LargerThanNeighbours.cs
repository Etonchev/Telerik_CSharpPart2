using System;

class LargerThanNeighbours
{
    public static bool CheckLargerThanNeighbours(int index, int[] array)
    {
        if (index <= 0 || index >= array.Length)
        {
            throw new ArgumentOutOfRangeException();
        }
        if (array[index - 1] < array[index] && array[index + 1] < array[index])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        int[] array = { 1, 2, 3, 3, 5, 4, 3, 9 };
        Console.WriteLine(CheckLargerThanNeighbours(3, array));
    }
}
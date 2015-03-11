using System;

class SortingArray
{
    public static int MaxInPortion(int[] array, int startIndex)
    {
        if (startIndex != array.Length)
        {
            return Math.Max(array[startIndex], MaxInPortion(array, ++startIndex));
        }
        return Int32.MinValue;
    }
    public static void SortDescending(ref int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int currentMax = MaxInPortion(array, i);
            int currentMaxIndex = Array.IndexOf(array, currentMax);
            array[currentMaxIndex] = array[i];
            array[i] = currentMax;
        }
    }
    public static void SortAscending(ref int[] array)
    {
        SortDescending(ref array);
        Array.Reverse(array);

    }
    static void Main()
    {
        int[] array = { 1, 2, 3, 3, 11, 4, 3, 9 };
        SortDescending(ref array);
        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
        SortAscending(ref array);
        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}
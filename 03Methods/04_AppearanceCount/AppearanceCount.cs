using System;

class AppearanceCount
{
    public static int ElementCounter(int element, int[] array)
    {
        int elementCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == element)
            {
                elementCount++;
            }
        }

        return elementCount;
    }
    static void Main()
    {
        int[] array = { 1, 2, 3, 3, 5, 6, 3, 9 };
        Console.WriteLine(ElementCounter(3, array));
    }
}
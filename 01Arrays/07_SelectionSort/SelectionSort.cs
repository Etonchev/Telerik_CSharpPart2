using System;

class SelectionSort
{
    static void Main()
    {
        int[] array = { 3, 2, 1, 5, 2, 4, 1 };
        for (int i = 0; i < array.Length; i++)
        {
            int minElem = Int32.MaxValue;
            int minElemIndex = 0;
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < minElem)
                {
                    minElem = array[j];
                    minElemIndex = j;
                }
            }
            int temp = array[i];
            array[i] = array[minElemIndex];
            array[minElemIndex] = temp;
        }

        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }

        Console.WriteLine();
    }
}
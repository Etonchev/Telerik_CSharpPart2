using System;

class NumverAsArray
{
    public static void InsertZeroes(ref int[] first, ref int[] second)
    {
        if (first.Length > second.Length)
        {
            Array.Resize<int>(ref second, first.Length);
            for (int i = second.Length; i < first.Length; i++)
            {
                second[i] = 0;
            }
        }
        else
        {
            Array.Resize<int>(ref first, second.Length);
            for (int i = first.Length; i < second.Length; i++)
            {
                first[i] = 0;
            }
        }
    }
    public static int[] AddArrays(int[] first, int[] second)
    {
        InsertZeroes(ref first, ref second);
        int[] result = new int[first.Length + 1];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
        {
            if (first[i] + second[i] + result[i] <= 9)
            {
                result[i] = first[i] + second[i] + result[i];
            }
            else
            {
                result[i + 1] = (first[i] + second[i] + result[i]) / 10;
                result[i] = (first[i] + second[i] + result[i]) % 10;
            }
        }

        return result;
    }
    static void Main()
    {
        int[] first = { 1, 1 };
        int[] second = { 8, 8, 8 };
        int[] result = AddArrays(first, second);
        foreach (var item in result)
        {
            Console.Write(item);
        }

        Console.WriteLine();
    }
}
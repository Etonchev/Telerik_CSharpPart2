using System;

class MaximalKSum
{
    static void Main()
    {
        Console.WriteLine("Arrays size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("K: ");
        int k = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{i}] = ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(array);
        for (int i = array.Length - 1; i > array.Length - k - 1; i--)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine();
    }
}
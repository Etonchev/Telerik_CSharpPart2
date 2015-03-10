using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.Write("n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}] = ", i);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.Write("k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        Array.Sort(array);
        int result;
        if (array[0] > k)
        {
            Console.WriteLine("There is no number <= k");
        }
        else
        {
            int index = Array.BinarySearch(array, k);
            if (index >= 0)
            {
                result = array[index];
            }
            else
            {
                result = array[~index - 1];
                Console.WriteLine(result);
            }
        }
    }
}
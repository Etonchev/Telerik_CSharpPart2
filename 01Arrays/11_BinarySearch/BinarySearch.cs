using System;

class BinarySearch
{
    static public int binarySearch (int[] array, int key, int low, int high)
    {
        if (low > high)
        {
            return -1;
        }
        int middle = (low + high) / 2;
        if (array[middle] == key)
        {
            return middle;
        }
        else if (key < array[middle])
        {
            return binarySearch(array, key, low, middle - 1);
        }
        else
        {
            return binarySearch(array, key, middle + 1, high);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("arr[{0}]: ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Number to search for: ");
        int key = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number is in position {0}", binarySearch(arr, key, 0, arr.Length));
    }
}
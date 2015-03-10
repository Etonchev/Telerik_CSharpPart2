using System;

class FindSumInArray
{
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
        Console.WriteLine("Enter sum to look for: ");
        int sum = Convert.ToInt32(Console.ReadLine());
        int startIndex = -1;
        int endIndex = -1;
        int currentSum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            currentSum = 0;
            for (int j = i; j < arr.Length; j++)
            {
                currentSum += arr[j];
                if (currentSum == sum)
                {
                    startIndex = i;
                    endIndex = j;
                }
            }
        }

        if (startIndex != -1)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write("{0}, ", arr[i]);
            }
        }
        else
        {
            Console.WriteLine("No elements fit the criteria !");
        }
    }
}
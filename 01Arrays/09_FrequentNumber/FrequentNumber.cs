using System;

class FrequentNumber
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

        int mostFrequentElement = -1;
        int mostFrequentElementCount = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            int currentElement = arr[i];
            int currentElementCount = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == currentElement)
                {
                    currentElementCount++;
                }
            }

            if (currentElementCount > mostFrequentElementCount)
            {
                mostFrequentElementCount = currentElementCount;
                mostFrequentElement = currentElement;
            }
        }

        Console.WriteLine("{0} ({1} times)", mostFrequentElement, mostFrequentElementCount);
    }
}
using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Arrays size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("firstArray[{i}] = ");
            firstArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("secondArray[{i}] = ");
            secondArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
            }
            else
            {
                Console.WriteLine("{0} != {1}", firstArray[i], secondArray[i]);
            }
        }
    }
}
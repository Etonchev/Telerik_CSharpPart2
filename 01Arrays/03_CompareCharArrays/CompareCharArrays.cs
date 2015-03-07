using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Arrays size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        char[] firstArray = new char[n];
        char[] secondArray = new char[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("firstArray[{i}] = ");
            firstArray[i] = Convert.ToChar(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("secondArray[{i}] = ");
            secondArray[i] = Convert.ToChar(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
            }
            else if ((int)firstArray[i] > (int)secondArray[i])
            {
                Console.WriteLine("{0} is after {1}", firstArray[i], secondArray[i]);
            }
            else
            {
                Console.WriteLine("{0} is before {1}", firstArray[i], secondArray[i]);
            }
        }
    }
}
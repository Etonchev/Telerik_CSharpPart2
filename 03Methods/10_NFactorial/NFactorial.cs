using System;
using System.Numerics;

public class NFactorial
{
    public static BigInteger Factorial(int n)
    {
        BigInteger result = 1;
        while (n > 0)
        {
            result *= n;
            n--;
        }

        return result;
    }
    public static void Main()
    {
        int[] array = new int[100];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        foreach (var item in array)
        {
            Console.Write("{0}, ", Factorial(item));
        }
    }
}
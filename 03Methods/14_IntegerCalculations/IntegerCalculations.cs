using System;

public class IntegerCalculations
{
    public static int Minimum(params int[] numbers)
    {
        int minimum = numbers[0];
        foreach (var item in numbers)
        {
            if (item < minimum)
            {
                minimum = item;
            }
        }

        return minimum;
    }
    public static int Maximum(params int[] numbers)
    {
        int maximum = numbers[0];
        foreach (var item in numbers)
        {
            if (item > maximum)
            {
                maximum = item;
            }
        }

        return maximum;
    }
    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }

        return sum;
    }
    public static int Average(params int[] numbers)
    {
        int average = Sum(numbers) / numbers.Length;
        return average;
    }
    public static int Product(params int[] numbers)
    {
        int product = 1;
        foreach (var item in numbers)
        {
            product *= item;
        }

        return product;
    }
    public static void Main()
    {
        Console.WriteLine(Minimum(1, 2, 3));
        Console.WriteLine(Maximum(1, 2, 3));
        Console.WriteLine(Sum(1, 2, 3));
        Console.WriteLine(Average(1, 2, 3));
        Console.WriteLine(Product(1, 2, 3));
    }
}
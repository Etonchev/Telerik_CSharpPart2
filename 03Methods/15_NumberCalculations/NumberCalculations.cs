using System;

public class IntegerCalculations
{
    public static dynamic Minimum(params int[] numbers)
    {
        dynamic minimum = numbers[0];
        foreach (var item in numbers)
        {
            if (item < minimum)
            {
                minimum = item;
            }
        }

        return minimum;
    }
    public static dynamic Maximum(params int[] numbers)
    {
        dynamic maximum = numbers[0];
        foreach (var item in numbers)
        {
            if (item > maximum)
            {
                maximum = item;
            }
        }

        return maximum;
    }
    public static dynamic Sum(params int[] numbers)
    {
        dynamic sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }

        return sum;
    }
    public static dynamic Average(params int[] numbers)
    {
        dynamic average = Sum(numbers) / numbers.Length;
        return average;
    }
    public static dynamic Product(params int[] numbers)
    {
        dynamic product = 1;
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
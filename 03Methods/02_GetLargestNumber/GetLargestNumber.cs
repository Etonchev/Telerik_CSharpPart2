using System;

class GetLargestNumber
{
    public static int GetMax(int first, int second)
    {
        return Math.Max(first, second);
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int third = Convert.ToInt32(Console.ReadLine());
        int max = GetMax(first, GetMax(second, third));
        Console.WriteLine(max);
    }
}
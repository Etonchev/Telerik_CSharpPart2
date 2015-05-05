using System;

public class BinaryShort
{
    public static int FindBitAt(int number, int position)
    {
        int bit = ((1 << position) & number) >> position;
        return bit;
    }
    public static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 16; i >= 0; i--)
        {
            Console.Write(FindBitAt(number, i));
        }

        Console.WriteLine();
    }
}
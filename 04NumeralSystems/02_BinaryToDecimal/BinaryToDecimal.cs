using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary: ");
        string binary = Console.ReadLine();
        int decimalNumber = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            decimalNumber += (int)Math.Pow(2 , binary.Length - i - 1) * (int)Char.GetNumericValue(binary[i]);
        }

        Console.WriteLine(decimalNumber);
    }
}
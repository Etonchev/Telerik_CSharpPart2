using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter decimal: ");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());
        StringBuilder binary = new StringBuilder();
        while (decimalNumber > 0)
        {
            binary.Insert(0, decimalNumber % 2);
            decimalNumber /= 2;
        }

        Console.WriteLine(binary);
    }
}
using System;
using System.Text;

class DecimalToHexadecimal
{
    public static string decToHex(long dec)
    {
        switch (dec)
        {
            case 0:
                return "0";
            case 1:
                return "1";
            case 2:
                return "2";
            case 3:
                return "3";
            case 4:
                return "4";
            case 5:
                return "5";
            case 6:
                return "6";
            case 7:
                return "7";
            case 8:
                return "8";
            case 9:
                return "9";
            case 10:
                return "A";
            case 11:
                return "B";
            case 12:
                return "C";
            case 13:
                return "D";
            case 14:
                return "E";
            case 15:
                return "F";
            default:
                return " ";
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter decimal: ");
        int decimalNumber = Convert.ToInt32(Console.ReadLine());
        StringBuilder hexadecimal = new StringBuilder();
        while (decimalNumber > 0)
        {
            hexadecimal.Insert(0, decToHex(decimalNumber % 16));
            decimalNumber /= 16;
        }

        Console.WriteLine(hexadecimal);
    }
}
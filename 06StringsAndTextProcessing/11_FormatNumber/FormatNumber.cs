using System;
using System.Text;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        //decimal number
        Console.WriteLine("{0,15}", number);
        //hexadecimal number
        Console.WriteLine("{0,15:X}", number);
        //percentage 
        Console.WriteLine("{0,15:P}", number);
        //scientific notation
        Console.WriteLine("{0,15:E}", number);
    }
}
using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        //StringBuilder reversed = new StringBuilder();
        //foreach (var item in input)
        //{
        //    reversed.Insert(0, item);
        //}

        //Console.WriteLine(reversed);

        char[] inputChar = input.ToCharArray();
        Array.Reverse(inputChar);
        string reversed = new string(inputChar);
        Console.WriteLine(reversed);
    }
}
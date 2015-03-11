using System;

class ReverseNumber
{
    public static int ReverseDigits(int number)
    {
        int reversedNumber = 0;
        while(number > 0)
        {
            reversedNumber = reversedNumber * 10;
            reversedNumber += number % 10;
            number /= 10;
        }

        return reversedNumber;
    }
    static void Main()
    {
        Console.WriteLine(ReverseDigits(123456789));
    }
}
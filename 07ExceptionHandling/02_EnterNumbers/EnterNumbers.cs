using System;

class EnterNumbers
{
    public static int ReadNumber(int start, int end)
    {
        Console.WriteLine("Enter number in range [{0};{1}]", start, end);
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < start || number > end)
        {
            throw new ArgumentOutOfRangeException();
        }

        return number;
    }

    public static void Main()
    {
        int start = 1;
        int end = 20;
        for (int i = 0; i < 10; i++)
        {
            try
            {
                ReadNumber(start, end);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number not in range !");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
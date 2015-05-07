using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double result = Math.Sqrt(number);
            Console.WriteLine(result);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
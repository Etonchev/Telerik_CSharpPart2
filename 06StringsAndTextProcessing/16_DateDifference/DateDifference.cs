using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        string firstInput = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(firstInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date: ");
        string secondInput = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(secondInput, "dd.MM.yyyy", CultureInfo.InvariantCulture);
        double distance = (secondDate - firstDate).TotalDays;
        Console.WriteLine("Distance : {0} days", distance);
    }
}
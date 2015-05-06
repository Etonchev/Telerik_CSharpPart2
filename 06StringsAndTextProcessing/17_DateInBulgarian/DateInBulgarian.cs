using System;
using System.Globalization;
using System.Text;

class DateInBulgarian
{
    static void Main()
    {
        Console.WriteLine("Enter day.month.year hour:minute:second");
        string input = Console.ReadLine();
        DateTime date = DateTime.ParseExact(input, "d.M.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);
        Console.WriteLine("{0} {1}", date.ToString("dddd", CultureInfo.CreateSpecificCulture("bg-BG")), date);
    }
}
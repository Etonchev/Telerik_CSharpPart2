using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

class DatesFromTextInCanada
{
    static void Main()
    {
        string input = "This is sample text with 12.05.2000 as a test date.";
        string datePattern = @"\b\d{1,2}\.\d{1,2}.\d{4}";
        string[] words = input.Split(' ');
        foreach (var item in words)
        {
            if (Regex.IsMatch(item, datePattern))
            {
                Console.WriteLine(item);
                DateTime date = DateTime.ParseExact(item, "d.M.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString(new CultureInfo("en-Ca")));
            }
        }
    }
}
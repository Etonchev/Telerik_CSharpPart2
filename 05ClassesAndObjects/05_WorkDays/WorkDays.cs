using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WorkDays
{
    static int CalculateWorkDays(DateTime end)
    {
        int workdays = 0;
        for (DateTime today = DateTime.Now; today < end; today = (today.AddDays(1)))
        {
            if (!(today.DayOfWeek == DayOfWeek.Sunday) && !(today.DayOfWeek == DayOfWeek.Saturday))
            {
                workdays++;
            }
        }

        return workdays;
    }
    static void Main()
    {
        Console.Write("Enter end date: ");
        DateTime end = Convert.ToDateTime(Console.ReadLine());
        if (DateTime.Now > end)
        {
            Console.WriteLine("Wrong date !");
            return;
        }

        Console.WriteLine("Number of workdays: {0}", CalculateWorkDays(end));
    }
}

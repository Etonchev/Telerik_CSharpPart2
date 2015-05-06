using System;
using System.Text;
using System.Collections.Generic;

class ExtractEmails
{
    static void Main()
    {
        string input = "This is a test including emilkrassimirov@gmail.com as e-mail address. And then we ave another one, etonchev@gmail.com as a second e-mail address.";
        string[] words = input.Split(' ');
        List<string> emails = new List<string>();
        foreach (var item in words)
        {
            if (item.Contains("@"))
            {
                emails.Add(item);
            }
        }

        foreach (var item in emails)
        {
            Console.WriteLine(item);
        }
    }
}
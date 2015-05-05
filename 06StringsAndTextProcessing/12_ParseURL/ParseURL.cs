using System;
using System.Text;

class ParseURL
{
    static void Main()
    {
        string input = "http://telerikacademy.com/Courses/Courses/Details/212";
        StringBuilder protocol = new StringBuilder();
        StringBuilder server = new StringBuilder();
        StringBuilder resource = new StringBuilder();
        string[] url = input.Split('/', ':');
        protocol.Append(url[0]);
        server.Append(url[3]);
        for (int i = 4; i < url.Length; i++)
        {
            resource.Append('/');
            resource.Append(url[i]);
        }
        Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", protocol, server, resource);
    }
}
using System;
using System.Net;
using System.IO;

class DownloadFile
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                if (File.Exists(@"../../telerik.png"))
                {
                    throw new IOException();
                }

                webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "../../telerik.png");
                Console.WriteLine("File downloaded successfully");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("Invalid url address !");
            }
            catch (IOException)
            {
                Console.WriteLine("File already exists !");
            }
        }
    }
}
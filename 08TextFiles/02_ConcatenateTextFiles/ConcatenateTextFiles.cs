using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        StreamWriter concatenated = new StreamWriter(@"E:\concatenated.txt");
        using (concatenated)
        {
            StreamReader first = new StreamReader(@"E:\text1.txt");
            using (first)
            {
                string line = first.ReadLine();
                while (line != null)
                {
                    concatenated.WriteLine(line);
                    line = first.ReadLine();
                }
            }

            StreamReader second = new StreamReader(@"E:\text2.txt");
            using (second)
            {
                string line = second.ReadLine();
                while (line != null)
                {
                    concatenated.WriteLine(line);
                    line = second.ReadLine();
                }
            }

            Console.WriteLine("Concatenation successfull !");
        }
    }
}
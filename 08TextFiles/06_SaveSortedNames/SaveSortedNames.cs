using System;
using System.Collections.Generic;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"E:\names.txt");
        using (reader)
        {
            List<string> names = new List<string>();
            string line = reader.ReadLine();
            while (line != null)
            {
                names.Add(line);
                line = reader.ReadLine();
            }

            names.Sort();
            StreamWriter writer = new StreamWriter(@"E:\sortedNames.txt");
            using (writer)
            {
                foreach (var name in names)
                {
                    writer.WriteLine(name);
                }
            }
        }

        Console.WriteLine("File with sorted names created successfully !");
    }
}
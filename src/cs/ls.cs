using System;
using System.IO;

class ls
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

            foreach (DirectoryInfo d in dir.GetDirectories())
            {
                Console.WriteLine("{0, -30}\t directory", d.Name);
            }

            foreach (FileInfo f in dir.GetFiles())
            {
                Console.WriteLine("{0, -30}\t file", f.Name);
            }
        }
    }
}
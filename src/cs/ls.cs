using System;
using System.IO;

class ls
{
    static void Main(string[] args)
    {
        //TODO: add -a argument that shows hidden files with ls command
        DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory());

        foreach (FileInfo f in dir.GetFiles())
        {
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //if (!f.Name.StartsWith("."))
            //   Console.WriteLine(f.Name);
            //Console.ResetColor();
            Console.WriteLine("{0, -30} file", f.Name);
        }

        foreach (DirectoryInfo d in dir.GetDirectories())
        {
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //if (!d.Name.StartsWith("."))
            //    Console.WriteLine(d.Name);
            //Console.ResetColor();
            Console.WriteLine("{0, -30} directory", d.Name);
        }
        //TODO: fix green background color at the end
    }
}
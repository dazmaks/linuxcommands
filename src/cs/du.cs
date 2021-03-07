using System;
using System.IO;

public class du
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Error: need more arguments!\nUsage: du \"File Name\"");
        }
        else
        {
            for (int i = 0; i<args.Length; i++)
            {
                if (File.Exists(args[i]) == false)
                {
                    Console.WriteLine("Error: file {0} not found!", args[i]);
                }
                else
                {
                    FileInfo fi = new FileInfo(args[i]);
                    Console.WriteLine("{0, -30} {1} bytes", args[i], fi.Length);
                }
            }
        }
    }
}
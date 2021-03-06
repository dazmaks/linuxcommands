using System;
using System.IO;

class cat
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Error: need more arguments!\nUsage: cat \"File Name\"");
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
                    string contents = File.ReadAllText(args[i]);
                    Console.Write(contents);
                }
            }
        }
    }
}
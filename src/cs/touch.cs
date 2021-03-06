using System;
using System.IO;

class touch
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Error: need more arguments!\nUsage: touch \"File Name\"");
        }
        else
        {
            for (int i = 0; i<args.Length; i++)
            {
                if (File.Exists(args[i]) == true)
                {
                    Console.WriteLine("Error: file {0} exists!", args[i]);
                }
                else
                {
                    File.Create(args[i]);
                }
                
            }

        }
    }
}
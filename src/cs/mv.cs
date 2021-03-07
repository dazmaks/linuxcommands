using System;
using System.IO;

class mv
{
    static void Main(string[] args)
    {
        if (args.Length > 1){
            string path = @args[0];

            for (int i = 1; i<args.Length; i++)
            {
                try
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                    if (File.Exists(args[i]))
                    {
                        Console.WriteLine("Error: file {0} exists!", args[i]);
                    }else{
                        File.Move(path, args[i]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: {0} on file \"{1}\"", e.ToString(), args[i]);
                }
            }

        }else{
            Console.WriteLine("Error: need more arguments!\nUsage: mv \"File Name\"(to read) \"File Name\"(to write)");
        }
    }
}
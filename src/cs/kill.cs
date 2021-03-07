using System;
using System.Diagnostics;

public class kill
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Error: need more arguments!\nUsage: kill \"PID\"");
        }
        else
        {
            for (int i = 0; i<args.Length; i++)
            {
                Process Id = Process.GetProcessById(Int32.Parse(args[i]));
                Id.Kill();
            }
        }
    }
}
using System;
using System.Text;
using System.Diagnostics;

class ps
{
    static void Main()
    {
        Process[] mYProcs = Process.GetProcesses();

        Console.WriteLine("-----------------------------------------------------");
        Console.WriteLine("{0, -8} {1, -30} {2, -10}", "PID", "Process Name", "Status");
        Console.WriteLine("-----------------------------------------------------");

        foreach (Process p in mYProcs)
        {
            try
            {
                Console.WriteLine("{0, -8} {1, -30} {2, -10}", p.Id, p.ProcessName, p.Responding ? "Running" : "IDLE");
            }
            catch (Exception)
            {
                continue;
            }
        }
    }
}


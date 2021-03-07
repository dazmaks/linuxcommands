using System;
using System.IO;

class df
{
    static void Main()
    {
        DriveInfo[] allDrives = DriveInfo.GetDrives();

        foreach (DriveInfo d in allDrives)
        {
            Console.WriteLine("Drive: {0} ({1}, {2})",
                d.Name, d.DriveFormat, d.DriveType);
            if (d.IsReady == true)
            {

                Console.WriteLine(
                    "\tAvailable space:          {0, 15} GB",
                    d.TotalFreeSpace/1073741824);

                Console.WriteLine(
                    "\tUsed space:               {0, 15} GB",
                    (d.TotalSize - d.TotalFreeSpace)/1073741824);

                Console.WriteLine(
                    "\tSize of drive:            {0, 15} GB ",
                    d.TotalSize/1073741824);
                Console.WriteLine("\tPercentage free space:                {0:0.00}%",
                    (d.AvailableFreeSpace / (float)d.TotalSize) * 100);
            }
        }
    }
}
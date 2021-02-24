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
                    "\tAvailable space to current user:{0, 15} bytes",
                    d.AvailableFreeSpace);

                Console.WriteLine(
                    "\tTotal available space:          {0, 15} bytes",
                    d.TotalFreeSpace);

                Console.WriteLine(
                    "\tTotal size of drive:            {0, 15} bytes ",
                    d.TotalSize);
                double freeSpacePerc = (d.AvailableFreeSpace / (float)d.TotalSize) * 100;
                Console.WriteLine("\tPercentage free space:                         {0:0.00}%",
                    freeSpacePerc);
            }
        }
    }
}

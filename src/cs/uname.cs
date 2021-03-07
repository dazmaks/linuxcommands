using System;
using System.IO;
using System.Management;

class uname
{
    static void Main(string[] args)
    {
        ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
        foreach (ManagementObject mo in mos.Get()){
            Console.WriteLine(mo["Caption"]);
        }
    }
}
using System;
using System.IO;

class cp
{
    static void Main(string[] args)
    {
        if (args.Length == 2){
            string path = @args[0];
            string path2 = @args[1];
            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path)) {}
                }
                if (File.Exists(path2))
                File.Delete(path2);
                File.Copy(path, path2);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.ToString());
            }
        }else{
            if (args.Length < 2) {
                Console.WriteLine("Error: need more arguments!\nUsage: cp \"File Name\"(to read) \"File Name\"(to write)");
            }else{
                Console.WriteLine("Error: need less arguments!\nUsage: cp \"File Name\"(to read) \"File Name\"(to write)");
            }
        }
    }
}
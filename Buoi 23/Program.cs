using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string exeDirectory = AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine("Duong dan cua file exe la: " + exeDirectory);

            string sourceFilePath = @"E:\Lap trinh game\data.io";


            
            string destinationFolder = @"E:\GIA LAP";
            File.Copy(sourceFilePath,destinationFolder);
            Console.ReadKey();
        }
    }
}

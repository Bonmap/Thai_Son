using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace hinhchunhat
{
    class Program
    {
        public static int ProductStatus = 1;
        

        static void Main()
        {
            int status = ProductStatus;
            Console.WriteLine(status);
            Console.ReadKey();
        }
    }
}
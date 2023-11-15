using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    internal class Program
    {
        const int SLOW = 1, MEDIUM = 2, FAST = 3;
        static void Main(string[] args)
        {
            Fan f1 = new Fan(FAST, true, 10, "yellow");
            Fan f2 = new Fan(MEDIUM, true, 5, "blue");

            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.ReadKey();
        }
    }
}

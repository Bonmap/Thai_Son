using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fan
{
    public class program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan(Fan.FAST, true, 10, "yellow");
            Fan fan2 = new Fan(Fan.MEDIUM, false, 5, "blue");
            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
            Console.ReadKey();
        }
    }
}

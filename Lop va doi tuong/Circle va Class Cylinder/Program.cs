using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_va_Class_Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Cricle cricle = new Cricle(6, "yellow");
            Cylinder cylinder = new Cylinder(12.3, "blue", 4.8);

            Console.WriteLine(cricle);
            Console.WriteLine(cylinder);
            Console.WriteLine(cylinder.The_tich());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Point2D_and_Class_Point3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D point2d = new Point2D(3.2f,6.8f);
            Console.WriteLine(point2d);
            Point3D point3d = new Point3D(4.6f, 5, 9);
            Console.WriteLine(point3d);
            Point3D point13d = new Point3D(4.8f, 8.8f, 9);
            Console.WriteLine(point13d);
            Console.ReadLine();
        }
    }
}

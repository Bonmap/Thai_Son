using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinhchunhat
{
    public class program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("Enter the width:");
            double width = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height:");
            double height = Double.Parse(Console.ReadLine());
            Rectangle rectangle1 = new Rectangle(width,height);
            Console.WriteLine("Your Rectangle \n" + rectangle1.Display());
            Console.WriteLine("Perimeter of the Rectangle: " + rectangle1.GetPerimeter());
            Console.WriteLine("Area of the Rectangle: " + rectangle1.GetArea());
            Console.ReadKey();
        }
    }
}

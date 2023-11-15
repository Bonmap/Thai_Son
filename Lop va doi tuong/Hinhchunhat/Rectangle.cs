using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinhchunhat
{

    public class Rectangle
    {
        private double width, height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        public double GetArea()
        {
            return width * height;
        }
        public double GetPerimeter()
        {
            return (width + height) * 2;
        }
        public string Display()
        {
            return "Rectangle {" + "width=" + width + ", height=" + height + "}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_va_Class_Cylinder
{
    public class Cylinder : Cricle
    {
        private double height;
        public Cylinder(double radius = 3.8, string color = "yellow", double height = 3.2) : base(radius, color)
        {
            this.height = height;
        }
        public double Height { get => height; set => height = value; }
        public double The_tich()
        {
            return height * (Math.PI * Radius * Radius);
        }
        public override string ToString()
        {
            return string.Format("Radius = {0}| Color = {1}| Height = {2}", Radius, Color, height);
        }
    }
}

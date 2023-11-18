using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_va_Class_Cylinder
{
    public class Cricle
    {
        private double radius;
        private string color;

        public Cricle(double radius = 3.5, string color = "blue")
        {
            this.radius = radius;
            this.color = color;
        }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public virtual double Dt()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override string ToString()
        {
            return string.Format("Radius:{0}| Color: {1}", radius, color);
        }
    }
}

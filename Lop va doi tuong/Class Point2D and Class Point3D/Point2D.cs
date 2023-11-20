using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Point2D_and_Class_Point3D
{
    class Point2D
    {
        private float x, y;

        public Point2D(float x=0, float y=0)
        {
            this.x = x;
            this.y = y;
        }
        public List<float> GetXY()
        {
            List<float> result = new List<float>();
            result.Add(this.x);
            result.Add(this.y);
            return result;
        }
        public void SetXY(float x=0,float y=0)
        {
            this.x = x;
            this.y = y;
        }
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }
}

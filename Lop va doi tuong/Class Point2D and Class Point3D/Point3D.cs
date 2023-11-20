using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Point2D_and_Class_Point3D
{
    class Point3D : Point2D
    {
        private float z;
        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float Z { get => z; set => z = value; }
        public List<float> GetXYZ()
        {
            List<float> result1 = new List<float>();
            result1 = base.GetXY();
            result1.Add(z);
            return result1;
        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X, Y, Z);
        }
    }
}

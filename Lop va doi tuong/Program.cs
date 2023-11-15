using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lop_va_doi_tuong
{
    public class program
    {
        static void Main(string[] args)
        {
            diem A = new diem();
            A.x = 5; A.y = 7; A.z = 9;
            diem B = new diem();
            B.x = 8; B.y = 2; B.z = 1;
            Console.WriteLine(A.ToString());
            Console.WriteLine(B);
            PS ps1 = new PS(5, 8);
            Console.WriteLine(ps1.ToString());
            Console.WriteLine(ps1.SayHello());
            Console.ReadKey();
           
        }
    }
    public class diem
    {
        public int x, y, z;
        public diem() { }
        public diem(int _x, int _y, int _z) { x = _x; y = _y; z = _z; }
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", x, y, z);
        }
    }
    public class PS
    {
        private int tu, mau;

        public PS(int tu=0, int mau=1)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public int Tu { get => tu; set => tu = value; }
        public int Mau { get => mau; set => mau = value; }

        public override string ToString()
        {
            return string.Format("{0}/{1}", tu, mau);
        }
        public string SayHello()
        {
            return "Hello!";
        }
    }
}

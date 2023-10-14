using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tim_so_lon_nhat_va_so_nho_nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b, c;
            int luot_dem = 4;
            Console.WriteLine("Chương trình tìm số lớn nhất và nhỏ nhất");
        nhap_so:
            Console.WriteLine("Nhập số a,b và c");
            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Số a là " + a);
                Console.WriteLine("Số b là " + b);
                Console.WriteLine("Số c là " + c);
            }
            else
            {
                luot_dem--;
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    goto quy_dinh;
                }
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
                goto nhap_so;
            }
            if (a > b && a > c)
            {
                Console.WriteLine(a + " là số lớn nhất");
                if (b > c) Console.WriteLine(c + " là số nhỏ nhất");
                else Console.WriteLine(b + " là số nhỏ nhất");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " là số lớn nhất");
                if (a > c) Console.WriteLine(c + " là số nhỏ nhất");
                else Console.WriteLine(a + " là số nhỏ nhất");
            }
            else 
            {
                Console.WriteLine(c + " là số lớn nhất");
                if (a > b) Console.WriteLine(b + " là số nhỏ nhất");
                else Console.WriteLine(a + " là số nhỏ nhất");
            }
            Console.ReadKey();
            return;
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
    }
}

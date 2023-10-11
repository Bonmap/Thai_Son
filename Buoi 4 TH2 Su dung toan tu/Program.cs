using System;
using System.Text;

namespace Buoi_4_TH2_Su_dung_toan_tu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double chieu_dai;
            double chieu_rong;
            Console.WriteLine("Tính diện tích một hình chữ nhật");
            Console.WriteLine("Vui lòng nhập chiều dài. Đơn vị là m");
            chieu_dai = double.Parse(Console.ReadLine());
            Console.WriteLine("Vui lòng nhập chiều rộng. Đơn vị là m");
            chieu_rong = double.Parse(Console.ReadLine());
            double dien_tich = chieu_dai * chieu_rong;
            Console.WriteLine("Diện tích hình chữ nhật là "+ dien_tich+ " m2");
            Console.ReadKey();
        }
    }
}

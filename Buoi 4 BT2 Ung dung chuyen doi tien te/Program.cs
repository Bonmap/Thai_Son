using System;
using System.Text;

namespace Buoi_4_BT2_Ung_dung_chuyen_doi_tien_te
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int usd;
            int vnd;
            const int ti_gia = 23000;
            Console.WriteLine("Ứng dụng chuyển đổi tiền USD thành VND");
            Console.WriteLine("Vui lòng nhập số tiền USD");
            usd = int.Parse(Console.ReadLine());
            vnd = usd * ti_gia;
            Console.WriteLine(usd+" USD tương đương "+vnd+" VNĐ");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong_trinh_xuat_so_ngay_trong_thang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int thang;
            int luot_dem = 4;
            Console.WriteLine("Chương trình xuất số ngày trong tháng");
        nhap_so:
            Console.WriteLine("Nhập số tháng. Ví dụ:3,5...");
            if (int.TryParse(Console.ReadLine(), out thang) && thang > 0 && thang < 13)
            {
                Console.WriteLine("Bạn nhập tháng " + thang);
                switch (thang)
                {
                    case 1:
                        Console.WriteLine("Số ngày trong tháng là 31 ngày");
                        break;
                    case 2:
                        Console.WriteLine("Số ngày trong tháng là 28 ngày");
                        break;
                    case 3:
                        Console.WriteLine("Số ngày trong tháng là 31 ngày");
                        break;
                    case 4:
                        Console.WriteLine("Số ngày trong tháng là 30 ngày");
                        break;
                    case 5:
                        Console.WriteLine("Số ngày trong tháng là 31 ngày");
                        break;
                    case 6:
                        Console.WriteLine("Số ngày trong tháng là 30 ngày");
                        break;
                    case 7:
                        Console.WriteLine("Số ngày trong tháng là 31 ngày");
                        break;
                    case 8:
                        Console.WriteLine("Số ngày trong tháng là 31 ngày");
                        break;
                    case 9:
                        Console.WriteLine("Số ngày trong tháng là 30 ngày");
                        break;
                    case 10:
                        Console.WriteLine("Số ngày trong tháng là 31 ngày");
                        break;
                    case 11:
                        Console.WriteLine("Số ngày trong tháng là 30 ngày");
                        break;
                    case 12:
                        Console.WriteLine("Số ngày trong tháng là 31 ngày");
                        break;
                }
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
            Console.ReadKey();
            return;
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
    }
}

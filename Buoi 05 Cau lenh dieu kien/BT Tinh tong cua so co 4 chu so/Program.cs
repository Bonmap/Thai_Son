using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tinh_tong_cua_so_co_4_chu_so
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            int so_1, so_2, so_3, so_4;
            int luot_dem = 4;
            Console.WriteLine("Chương trình tính tổng của số 4 chữ số abcd (tổng = ad+bc)");
        nhap_so:
            Console.WriteLine("Nhập số 4 con số. Ví dụ: 1248");
            if (int.TryParse(Console.ReadLine(), out a) && a < 10000)
            {
                so_1 = a / 1000;
                so_2 = a % 1000 / 100;
                so_3 = a % 100 / 10;
                so_4 = a - so_1 * 1000 - so_2 * 100 - so_3 * 10;
                Console.WriteLine("Số bạn nhập " + "số a là " + so_1 + ".số b là " + so_2 + ".số c là " + so_3 + ".số d là " + so_4);
                int ket_qua = (so_1 * 10 + so_4) + (so_2 * 10 + so_3);
                Console.WriteLine("Tổng của số ad+bc = "+ ket_qua);
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

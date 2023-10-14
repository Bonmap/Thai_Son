using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Kiem_tra_so_chinh_phuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            int can_bac_hai;
            int luot_dem = 4;
            Console.WriteLine("Chương trình kiểm tra số chính phương");
        nhap_so:
            Console.WriteLine("Vui lòng Nhập số");
            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Số bạn nhập là " + a);
                can_bac_hai = Convert.ToInt16(Math.Sqrt(a));
                //if (can_bac_hai == Math.Sqrt(a))
                if (can_bac_hai*can_bac_hai == a)
                       Console.WriteLine("yes");
                else Console.WriteLine("no");
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

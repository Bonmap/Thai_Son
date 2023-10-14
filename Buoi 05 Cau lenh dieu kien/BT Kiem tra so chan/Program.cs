using System;
using System.Text;

namespace BT_Kiem_tra_so_chan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            int luot_dem = 4;
            Console.WriteLine("Chương trình kiểm tra số chẵn");
        nhap_so:
            Console.WriteLine("Vui lòng Nhập số");
            if (int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Số bạn nhập là " + a);
                if (a%2==0) Console.WriteLine("yes");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_ve_nha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            bool so_nguyen_to = true;
            int luot_dem = 4;
            Console.WriteLine("Chương trình kiểm tra số nguyên tố");
            Console.WriteLine("Vui lòng nhập số ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                luot_dem--;
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    goto quy_dinh;
                }
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
            }
            Console.WriteLine("số bạn nhập là " + a);
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) so_nguyen_to = false;
            }
            if (so_nguyen_to) Console.WriteLine("số " + a + " là số nguyên tố");
            else Console.WriteLine("số " + a + " không phải là số nguyên tố");
            Console.ReadKey();
            return;
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
    }    
}

